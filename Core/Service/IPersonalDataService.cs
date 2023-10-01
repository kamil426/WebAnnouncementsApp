﻿using WebAnnouncementsApp.Core.Models.Domains;

namespace WebAnnouncementsApp.Core.Service
{
    public interface IPersonalDataService
    {
        public PersonalData GetPersonalData(string userId);
        public ICollection<PhoneNumber> GetPhoneNumbers(string userId);
        public void AddEditPersonalData(PersonalData personalData, List<string> newPhoneNumbers, List<string> phoneNumbersDoNotDelete);
        public PersonalData GetPersonalData(int id);
    }
}
