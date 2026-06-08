using DVLD.Application.DTOs;
using DVLD.Application.Services;
using DVLD.Infrastructure.Services;
using DVLD.WinForms.Properties;

namespace DVLD.People
{
    public partial class frmAddUpdatePerson : Form
    {
        public enum enMode { AddNew, Update};

        private enMode _mode;
        private int _PersonId;
        private CountriesService _countries;
        private PeopleService _people;
        PersonDto _person;

        public frmAddUpdatePerson(CountriesService countries, PeopleService people)
        {
            InitializeComponent();
            _mode = enMode.AddNew;
            _countries = countries;
            _people = people;
            _person = new PersonDto();
        }

        public frmAddUpdatePerson(int PersonId, CountriesService countries, PeopleService people)
        {
            InitializeComponent();
            _mode = enMode.Update;
            _PersonId = PersonId;
            _countries = countries;
            _people = people;
        }

        private async void frmAddUpdatePerson_Load(object sender, EventArgs e)
        {
            await ResetDefualtValues();

            if (_mode == enMode.Update)
                await LoadPersonDataAsync();
        }

        private async Task LoadCountriesAsync()
        {
            var Countries = await _countries.GetCountryNameAsync();

            cbCountry.DataSource = Countries;
            cbCountry.DisplayMember = "CountryName";
            cbCountry.ValueMember = "CountryID";
        }

        private async Task LoadPersonDataAsync()
        {
            _person = await _people.GetByIdAsync(_PersonId);

            if (_person == null)
            {
                MessageBox.Show("No Person with ID = " + _PersonId, "Person Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
                return;
            }

            lblPersonID.Text = _person.PersonID.ToString();
            txtFirstName.Text = _person.FirstName;
            txtSecondName.Text = _person.SecondName;
            txtThirdName.Text = _person.ThirdName;
            txtLastName.Text = _person.LastName;
            txtNationalNo.Text = _person.NationalNo;
            dtpDateOfBirth.Value = _person.DateOfBirth;

            if (_person.Gendor == 1)
                rbMale.Checked = true;
            else
                rbFemale.Checked = true;

            txtAddress.Text = _person.Address;
            txtPhone.Text = _person.Phone;
            txtEmail.Text = _person.Email;
            cbCountry.SelectedValue = _person.NationalityCountryID;

            if (_person.ImagePath != "")
            {
                pbPersonImage.ImageLocation = _person.ImagePath;

            }

            llRemoveImage.Visible = (_person.ImagePath != "");
        }

        private async Task ResetDefualtValues()
        {
            await LoadCountriesAsync();

            if (_mode == enMode.AddNew)
            {
                lblTitle.Text = "Add New Person";
            }
            else
            {
                lblTitle.Text = "Update Person";
            }

            if (rbMale.Checked)
                pbPersonImage.Image = Resources.Male_512;
            else
                pbPersonImage.Image = Resources.Female_512;

            llRemoveImage.Visible = (pbPersonImage.ImageLocation != null);

            dtpDateOfBirth.MaxDate = DateTime.Now.AddYears(-18);
            dtpDateOfBirth.Value = dtpDateOfBirth.MaxDate;

            dtpDateOfBirth.MinDate = DateTime.Now.AddYears(-100);

            cbCountry.SelectedIndex = cbCountry.FindString("Iraq");

            txtFirstName.Text = "";
            txtSecondName.Text = "";
            txtThirdName.Text = "";
            txtLastName.Text = "";
            txtNationalNo.Text = "";
            rbMale.Checked = true;
            txtPhone.Text = "";
            txtEmail.Text = "";
            txtAddress.Text = "";
        }

        private bool _HandlePersonImage()
        {
            if (_person.ImagePath == pbPersonImage.ImageLocation)
                return true;

            if (string.IsNullOrWhiteSpace(pbPersonImage.ImageLocation))
            {
                _person.ImagePath = null;
                return true;
            }

            try
            {
                string newImagePath = UtilityService.CopyImage(pbPersonImage.ImageLocation);

                if (!string.IsNullOrWhiteSpace(_person.ImagePath)&& File.Exists(_person.ImagePath))
                    File.Delete(_person.ImagePath);

                _person.ImagePath = newImagePath;
                pbPersonImage.ImageLocation = newImagePath;

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return false;
            }
        }

        private void rbFemale_Click(object sender, EventArgs e)
        {
            if (pbPersonImage.ImageLocation == null)
                pbPersonImage.Image = Resources.Female_512;
        }

        private void rbMale_Click(object sender, EventArgs e)
        {
            if (pbPersonImage.ImageLocation == null)
                pbPersonImage.Image = Resources.Male_512;
        }

        private void llRemoveImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pbPersonImage.ImageLocation = null;

            if (rbMale.Checked)
                pbPersonImage.Image = Resources.Male_512;
            else
                pbPersonImage.Image = Resources.Female_512;

            llRemoveImage.Visible = false;
        }

        private void llSetImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string selectedFilePath = openFileDialog1.FileName;
                pbPersonImage.Load(selectedFilePath);
                llRemoveImage.Visible = true;
            }
        }

        private CreatePersonDto BuildCreateDto()
        {
            return new CreatePersonDto
            {
                NationalNo = txtNationalNo.Text.Trim(),
                FirstName = txtFirstName.Text.Trim(),
                SecondName = txtSecondName.Text.Trim(),
                ThirdName = txtThirdName.Text.Trim(),
                LastName = txtLastName.Text.Trim(),
                DateOfBirth = dtpDateOfBirth.Value,
                Gendor = rbMale.Checked ? (byte)1 : (byte)0,
                Address = txtAddress.Text.Trim(),
                Phone = txtPhone.Text.Trim(),
                Email = txtEmail.Text.Trim(),
                NationalityCountryID = (int)cbCountry.SelectedValue,
                ImagePath = pbPersonImage.ImageLocation
            };
        }

        private UpdatePersonDto BuildUpdateDto()
        {
            return new UpdatePersonDto
            {
                NationalNo = txtNationalNo.Text.Trim(),
                FirstName = txtFirstName.Text.Trim(),
                SecondName = txtSecondName.Text.Trim(),
                ThirdName = txtThirdName.Text.Trim(),
                LastName = txtLastName.Text.Trim(),
                DateOfBirth = dtpDateOfBirth.Value,
                Gendor = rbMale.Checked ? (byte)1 : (byte)0,
                Address = txtAddress.Text.Trim(),
                Phone = txtPhone.Text.Trim(),
                Email = txtEmail.Text.Trim(),
                NationalityCountryID = (int)cbCountry.SelectedValue,
                ImagePath = pbPersonImage.ImageLocation
            };
        }

        private async Task AddNewPersonAsync()
        {
            var dto = BuildCreateDto();

            var person = await _people.CreateAsync(dto);

            MessageBox.Show("Person Added Successfully","Success",MessageBoxButtons.OK,MessageBoxIcon.Information);

            _PersonId = person.PersonID;

            lblPersonID.Text = person.PersonID.ToString();

            _mode = enMode.Update;

            lblTitle.Text = "Update Person";
        }

        private async Task UpdatePersonAsync()
        {
            var dto = BuildUpdateDto();

            await _people.UpdateAsync(_PersonId, dto);

            MessageBox.Show("Person Updated Successfully","Success",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!_HandlePersonImage())
                return;

            try
            {
                btnSave.Enabled = true;

                if (_mode == enMode.AddNew)
                    await AddNewPersonAsync();
                else
                    await UpdatePersonAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            finally
            {
                btnSave.Enabled = true;
            }
        }
    }
}