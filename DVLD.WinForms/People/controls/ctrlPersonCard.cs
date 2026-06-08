using DVLD.Application.DTOs;
using DVLD.Infrastructure.Services;
using DVLD.People;
using DVLD.WinForms.Properties;
using Microsoft.Extensions.DependencyInjection;

namespace DVLD.Controls
{
    public partial class ctrlPersonCard : UserControl
    {
        private IServiceProvider _provider;
        private PeopleService _people;

        private int _PersonID = -1;
        public int PersonID { get { return _PersonID; } }

        public ctrlPersonCard()
        {
            InitializeComponent();
        }

        public ctrlPersonCard(IServiceProvider provider, PeopleService people) : this()
        {
            _provider = provider;
            _people = people;
        }

        public void SetServices(IServiceProvider provider, PeopleService people)
        {
            _provider = provider;
            _people = people;
        }

        public async Task LoadPersonInfo(int PersonId)
        {
            PersonDto People = await _people.GetByIdAsync(PersonId);

            if (People == null)
            {
                ResetPersonInfo();
                MessageBox.Show("No Person with PersonID = " + PersonID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            await _FillPersonInfo(People);
        }

        private void _LoadPersonImage(PersonDto dto)
        {
            if (dto.Gendor == 1)
                pbPersonImage.Image = Resources.Male_512;
            else
                pbPersonImage.Image = Resources.Female_512;

            if (string.IsNullOrWhiteSpace(dto.ImagePath))
                return;

            if (File.Exists(dto.ImagePath))
                pbPersonImage.Load(dto.ImagePath);
            else
                MessageBox.Show($"Could not find image:\n{dto.ImagePath}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private async Task _FillPersonInfo(PersonDto dto)
        {
            llEditPersonInfo.Enabled = true;
            _PersonID = dto.PersonID;
            lblPersonID.Text = dto.PersonID.ToString();
            lblNationalNo.Text = dto.NationalNo;
            lblFullName.Text = $"{dto.FirstName} {dto.SecondName} {dto.ThirdName} {dto.LastName}";
            lblGendor.Text = dto.Gendor == 0 ? "Female" : "Male";
            lblEmail.Text = dto.Email;
            lblPhone.Text = dto.Phone;
            lblDateOfBirth.Text = dto.DateOfBirth.ToShortDateString();
            lblCountry.Text = await _people.GetCountryNameById(dto.PersonID);
            lblAddress.Text = dto.Address;
            _LoadPersonImage(dto);
        }

        public void ResetPersonInfo()
        {
            _PersonID = -1;
            lblPersonID.Text = "[????]";
            lblNationalNo.Text = "[????]";
            lblFullName.Text = "[????]";
            pbGendor.Image = Resources.Man_32;
            lblGendor.Text = "[????]";
            lblEmail.Text = "[????]";
            lblPhone.Text = "[????]";
            lblDateOfBirth.Text = "[????]";
            lblCountry.Text = "[????]";
            lblAddress.Text = "[????]";
            pbPersonImage.Image = Resources.Male_512;
        }

        private async void llEditPersonInfo_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var frm = ActivatorUtilities.CreateInstance<frmAddUpdatePerson>(_provider, PersonID);
            frm.ShowDialog();

            await LoadPersonInfo(PersonID);
        }
    }
}