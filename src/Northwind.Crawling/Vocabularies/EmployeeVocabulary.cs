using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;
using CluedIn.Crawling.Northwind.Core.Constants;

namespace CluedIn.Crawling.Northwind.Vocabularies
{
    public class  EmployeeVocabulary : SimpleVocabulary
    {
        public  EmployeeVocabulary()
        {
            VocabularyName = "Northwind Employee"; 
            KeyPrefix      = "northwind.employee"; 
            KeySeparator   = ".";
            Grouping       = EntityType.Person; // TODO: Make sure EntityType is correct.

            //TODO: Make sure that any properties mapped into CluedIn Vocabulary are not in the group.
            AddGroup("Northwind Employee Details", group =>
            {
                EmployeeId = group.Add(new VocabularyKey("EmployeeId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LastName = group.Add(new VocabularyKey("LastName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FirstName = group.Add(new VocabularyKey("FirstName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Title = group.Add(new VocabularyKey("Title", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TitleOfCourtesy = group.Add(new VocabularyKey("TitleOfCourtesy", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BirthDate = group.Add(new VocabularyKey("BirthDate", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                HireDate = group.Add(new VocabularyKey("HireDate", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Address = group.Add(new VocabularyKey("Address", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                City = group.Add(new VocabularyKey("City", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Region = group.Add(new VocabularyKey("Region", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PostalCode = group.Add(new VocabularyKey("PostalCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Country = group.Add(new VocabularyKey("Country", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                HomePhone = group.Add(new VocabularyKey("HomePhone", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Extension = group.Add(new VocabularyKey("Extension", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Photo = group.Add(new VocabularyKey("Photo", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Notes = group.Add(new VocabularyKey("Notes", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReportsTo = group.Add(new VocabularyKey("ReportsTo", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PhotoPath = group.Add(new VocabularyKey("PhotoPath", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                
            });

            //TODO: If the property is already set in the clueproducer, it doesn't have to be here.

            //TODO: Don't forget to map all possible properties into already existing CluedIn Vocabularies.
            AddMapping(LastName, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInPerson.LastName);
            AddMapping(FirstName, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInPerson.FirstName);
            AddMapping(Title, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInPerson.Title);
            AddMapping(BirthDate, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInPerson.Birthday);
            AddMapping(Address, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInPerson.HomeAddress);
            AddMapping(City, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInPerson.HomeAddressCity);
            AddMapping(HomePhone, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInPerson.PhoneNumber);
        }


        
        public VocabularyKey EmployeeId { get; private set; }
        
        public VocabularyKey LastName { get; private set; }
        
        public VocabularyKey FirstName { get; private set; }
        
        public VocabularyKey Title { get; private set; }
        
        public VocabularyKey TitleOfCourtesy { get; private set; }
        
        public VocabularyKey BirthDate { get; private set; }
        
        public VocabularyKey HireDate { get; private set; }
        
        public VocabularyKey Address { get; private set; }
        
        public VocabularyKey City { get; private set; }
        
        public VocabularyKey Region { get; private set; }
        
        public VocabularyKey PostalCode { get; private set; }
        
        public VocabularyKey Country { get; private set; }
        
        public VocabularyKey HomePhone { get; private set; }
        
        public VocabularyKey Extension { get; private set; }
        
        public VocabularyKey Photo { get; private set; }
        
        public VocabularyKey Notes { get; private set; }
        
        public VocabularyKey ReportsTo { get; private set; }
        
        public VocabularyKey PhotoPath { get; private set; }
        
    }
}
