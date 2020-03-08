using eVotingSystem.CORE.Constants;
using eVotingSystem.CORE.Requests;
using eVotingSystem.Desktop;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eVotingSystem.Desktop.Helpers
{
    public class ComboBoxHelper
    {
        APIService _countryAPIService = new APIService("Country");
        APIService _CandidateAPIService = new APIService("Candidate");
        APIService _cityAPIService = new APIService("City");
        APIService _nationalityAPIService = new APIService("Nationality");
        APIService _PoliticalOrganizationAPIService = new APIService("PoliticalOrganization");
        APIService _ElectionCycleAPIService = new APIService("ElectionCycle");
        APIService _ElectionCycleElectiveListAPIService = new APIService("ElectionCycleElectiveList");
        APIService _ElectionOptionAPIService = new APIService("ElectionOption");
        APIService _ElectionRegionAPIService = new APIService("ElectionRegion");
        APIService _ElectionUnitAPIService = new APIService("ElectionUnit");
        APIService _ElectiveListAPIService = new APIService("ElectiveList");
        APIService _ElectiveListElectionOptionAPIService = new APIService("ElectiveListElectionOption");
        APIService _FileAPIService = new APIService("File");
        APIService _MessageAPIService = new APIService("Message");
        APIService _UserAPIService = new APIService("User");
        APIService _VoteAPIService = new APIService("Vote");
        APIService _VoterAPIService = new APIService("Voter");
        public async Task<ComboBox> GetCountries(ComboBox cmb)
        {
            var data = await _countryAPIService.Get<List<CountryDTO>>(null);
            foreach (var item in data)
            {
                var cmbItem = new ComboBoxItem
                {
                    Value = item.Id,
                    Text = item.Name
                };

                cmb.Items.Add(cmbItem);
            }

            return cmb;
        }
        public async Task<ComboBox> GetElectiveLists(ComboBox cmb)
        {
            var data = await _ElectiveListAPIService.Get<List<ElectiveListDTO>>(null);
            foreach (var item in data)
            {
                var cmbItem = new ComboBoxItem
                {
                    Value = item.Id,
                    Text = item.ElectionPositionName
                };

                cmb.Items.Add(cmbItem);
            }

            return cmb;
        }
        public async Task<ComboBox> GetElectiveLists(ComboBox cmb,int electionId)
        {
            var unit=await _ElectionUnitAPIService.Get<List<ElectionUnitDTO>>(new ElectionUnitSearchRequest() { Id=electionId});
            List<ElectionRegionDTO> regions=await _ElectionRegionAPIService.Get<List<ElectionRegionDTO>>(null);
            var unitsRegion = regions.Where(s => s.Id == unit[0].ElectionRegionId).FirstOrDefault();
            List<int> regionsIds = new List<int>();
            do
            {
                if (unitsRegion!=null)
                    regionsIds.Add( unitsRegion.Id);
                unitsRegion = regions.FirstOrDefault(s=>s.Id==unitsRegion.SuperiorElectionRegionDTOId);
            } while (unitsRegion != null);
            List<ElectiveListDTO> data = new List<ElectiveListDTO>();
            foreach (var item in regionsIds)
            {
            data.AddRange( await _ElectiveListAPIService.Get<List<ElectiveListDTO>>(new ElectiveListSearchRequest() { ElectionRegionId=item}));
            }
            foreach (var item in data)
            {
                var cmbItem = new ComboBoxItem
                {
                    Value = item.Id,
                    Text = item.ElectionPositionName
                };

                cmb.Items.Add(cmbItem);
            }

            return cmb;
        }
        public async Task<ComboBox> GetPoliticalOrientations(ComboBox cmb)
        {
            List<PoliticalOrientation> data = new List<PoliticalOrientation>();
            data.Add(PoliticalOrientation.Left);
            data.Add(PoliticalOrientation.LeftCenter);
            data.Add(PoliticalOrientation.Center);
            data.Add(PoliticalOrientation.CernterRight);
            data.Add(PoliticalOrientation.Right);
            data.Add(PoliticalOrientation.Undefind);
            for (int i = 0; i < 6; i++)
            {
                var cmbItem = new ComboBoxItem
                {
                    Value = i,
                    Text = data[i].ToString()
                };

                cmb.Items.Add(cmbItem);
            }

            return cmb;
        }
        public async Task<ComboBox> GetCandidates(ComboBox cmb)
        {
            var data = await _CandidateAPIService.Get<List<CandidateDTO>>(null);
            foreach (var item in data)
            {
                var cmbItem = new ComboBoxItem
                {
                    Value = item.Id,
                    Text = item.FirstName + " " + item.LastName
                };

                cmb.Items.Add(cmbItem);
            }

            return cmb;
        }
        public async Task<ComboBox> GetElectionOptionTypes(ComboBox cmb)
        {
            List<ElectionOptionType> data = new List<ElectionOptionType>();
            data.Add(ElectionOptionType.Candidate);
            data.Add(ElectionOptionType.PoliticalOrganization);
            for (int i = 0; i < 2; i++)
            {
                var cmbItem = new ComboBoxItem
                {
                    Value = i,
                    Text = data[i].ToString()
                };

                cmb.Items.Add(cmbItem);
            }

            return cmb;
        }
        public async Task<ComboBox> GetUserTypes(ComboBox cmb)
        {
            List<UserTypes> data = new List<UserTypes>();
            data.Add(UserTypes.Person);
            data.Add(UserTypes.Administrator);
            data.Add(UserTypes.Supervisor);
            for (int i = 0; i < 3; i++)
            {
                var cmbItem = new ComboBoxItem
                {
                    Value = i+1,
                    Text = data[i].ToString()
                };

                cmb.Items.Add(cmbItem);
            }

            return cmb;
        }
        public async Task<ComboBox> GetGenders(ComboBox cmb)
        {
            List<Gender> data = new List<Gender>();
            data.Add(Gender.Female);
            data.Add(Gender.Male);
            for (int i = 0; i < 2; i++)
            {
                var cmbItem = new ComboBoxItem
                {
                    Value = i,
                    Text = data[i].ToString()
                };

                cmb.Items.Add(cmbItem);
            }

            return cmb;
        }
        public async Task<ComboBox> GetSchoolingDegrees(ComboBox cmb)
        {
            List<SchoolingDegreeLevel> data = new List<SchoolingDegreeLevel>();
            data.Add(SchoolingDegreeLevel.Uneducated);
            data.Add(SchoolingDegreeLevel.Primary);
            data.Add(SchoolingDegreeLevel.Associate);
            data.Add(SchoolingDegreeLevel.Bachelor);
            data.Add(SchoolingDegreeLevel.Master);
            data.Add(SchoolingDegreeLevel.Doctoral);
            for (int i = 0; i < 6; i++)
            {
                var cmbItem = new ComboBoxItem
                {
                    Value = i,
                    Text = data[i].ToString()
                };

                cmb.Items.Add(cmbItem);
            }

            return cmb;
        }
        public async Task<ComboBox> GetCities(ComboBox cmb)
        {
            var data = await _cityAPIService.Get<List<CityDTO>>(null);

            foreach (var item in data)
            {
                var cmbItem = new ComboBoxItem { Value = item.Id, Text = item.Name };

                cmb.Items.Add(cmbItem);
            }

            return cmb;
        }
        public async Task<ListBox> GetElectiveLists(ListBox lstbox)
        {
            var data = await _ElectiveListAPIService.Get<List<ElectiveListDTO>>(null);

            foreach (var item in data)
            {
                lstbox.Items.Add(new { Value = item.Id, Text = item.ElectionPositionName });
            }

            return lstbox;
        }
        public async Task<ComboBox> GetNationalities(ComboBox cmb)
        {
            var data = await _nationalityAPIService.Get<List<NationalityDTO>>(null);

            foreach (var item in data)
            {
                var cmbItem = new ComboBoxItem { Value = item.Id, Text = item.Name };

                cmb.Items.Add(cmbItem);
            }

            return cmb;
        }

        public async Task<ComboBox> GetPoliticalOrganizations(ComboBox cmb)
        {
            var data = await _PoliticalOrganizationAPIService.Get<List<PoliticalOrganizationDTO>>(null);

            foreach (var item in data)
            {
                var cmbItem = new ComboBoxItem { Value = item.Id, Text = item.Name };

                cmb.Items.Add(cmbItem);
            }

            return cmb;
        }
        
        public async Task<ComboBox> GetElectionCycles(ComboBox cmb)
        {
            var data = await _ElectionCycleAPIService.Get<List<ElectionCycleDTO>>(null);

            foreach (var item in data)
            {
                var cmbItem = new ComboBoxItem { Value = item.Id, Text = item.Name };

                cmb.Items.Add(cmbItem);
            }

            return cmb;
        }
        
        //public async Task<ComboBox> GetElectionCycleElectiveLists(ComboBox cmb)
        //{
        //    var data = await _ElectionCycleElectiveListAPIService.Get<List<ElectionCycleElectiveListDTO>>(null);

        //    foreach (var item in data)
        //    {
        //        var cmbItem = new ComboBoxItem { Value = item.Id, Text = item.Name };

        //        cmb.Items.Add(cmbItem);
        //    }

        //    return cmb;
        //}
        
        public async Task<ComboBox> GetElectionOptions(ComboBox cmb)
        {
            var data = await _ElectionOptionAPIService.Get<List<ElectionOptionDTO>>(null);

            foreach (var item in data)
            {
                var cmbItem = new ComboBoxItem { Value = item.Id, Text = item.ElectionOptionType==ElectionOptionType.Candidate?item.Candidate.FirstName+" "+item.Candidate.LastName:item.PoliticalOrganization.Name };

                cmb.Items.Add(cmbItem);
            }

            return cmb;
        }
        
        public async Task<ComboBox> GetElectionRegions(ComboBox cmb)
        {
            var data = await _ElectionRegionAPIService.Get<List<ElectionRegionDTO>>(null);

            foreach (var item in data)
            {
                var cmbItem = new ComboBoxItem { Value = item.Id, Text = item.Name };

                cmb.Items.Add(cmbItem);
            }

            return cmb;
        }
        
        public async Task<ComboBox> GetElectionUnits(ComboBox cmb)
        {
            var data = await _ElectionUnitAPIService.Get<List<ElectionUnitDTO>>(null);

            foreach (var item in data)
            {
                var cmbItem = new ComboBoxItem { Value = item.Id, Text = item.Name };

                cmb.Items.Add(cmbItem);
            }

            return cmb;
        }

        public async Task<CheckedListBox> GetElectiveListElectionOptions(CheckedListBox cmb)
        {
            var data = await _ElectiveListElectionOptionAPIService.Get<List<ElectiveListElectionOptionDTO>>(null);

            foreach (var item in data)
            {
                var p = await _CandidateAPIService.GetById<CandidateDTO>(item.ElectionOptionId);

                cmb.Items.Add(p);
            }

            return cmb;
        }
        public async Task<CheckedListBox> GetElectiveListElectionOptions(CheckedListBox cmb, int electionId)
        {
            var data = await _ElectiveListElectionOptionAPIService.Get<List<ElectiveListElectionOptionDTO>>(null);

            foreach (var item in data)
            {
                var p = await _CandidateAPIService.GetById<CandidateDTO>(item.ElectionOptionId);

                cmb.Items.Add(p);
            }

            return cmb;
        }
        public async Task<ComboBox> GetElectiveListElectionOptions(ComboBox cmb,int listId)
        {
            var data = await _ElectiveListElectionOptionAPIService.Get<List<ElectiveListElectionOptionDTO>>(new ElectiveListElectionOptionSearchRequest() { ElectiveListId=listId});

            foreach (var item in data)
            {
                List<ElectionOptionDTO> b =await _ElectionOptionAPIService.Get<List<ElectionOptionDTO>>(new ElectionOptionSearchRequest() { Id= item.ElectionOptionId });
                var a = b[0];
                if (a != null)
                {

                if (a.ElectionOptionType==ElectionOptionType.PoliticalOrganization)
                {
                    var p = await _PoliticalOrganizationAPIService.Get<List<PoliticalOrganizationDTO>>(new PoliticalOrganizationSearchRequest() { Id = (int)a.PoliticalOrganizationId.Value });
                    var cmbItem = new ComboBoxItem { Value = b[0].Id, Text = p[0].Name };
                cmb.Items.Add(cmbItem);
                }
                }
            }

            return cmb;
        }

        public async Task<ComboBox> GetFiles(ComboBox cmb)
        {
            var data = await _FileAPIService.Get<List<FileDTO>>(null);

            foreach (var item in data)
            {
                var cmbItem = new ComboBoxItem { Value = item.Id, Text = item.Name };

                cmb.Items.Add(cmbItem);
            }

            return cmb;
        }
        
        //public async Task<ComboBox> GetMessages(ComboBox cmb)
        //{
        //    var data = await _MessageAPIService.Get<List<MessageDTO>>(null);

        //    foreach (var item in data)
        //    {
        //        var cmbItem = new ComboBoxItem { Value = item.Id, Text = item.Receiver.FirstName+" "+item.Receiver.LastName };

        //        cmb.Items.Add(cmbItem);
        //    }

        //    return cmb;
        //}
        
        public async Task<ComboBox> GetUsers(ComboBox cmb)
        {
            var data = await _UserAPIService.Get<List<UserDTO>>(null);

            foreach (var item in data)
            {
                var cmbItem = new ComboBoxItem { Value = item.Id, Text = item.FirstName+" "+item.LastName };

                cmb.Items.Add(cmbItem);
            }

            return cmb;
        }
        
        //public async Task<ComboBox> GetVotes(ComboBox cmb)
        //{
        //    var data = await _VoteAPIService.Get<List<VoteDTO>>(null);

        //    foreach (var item in data)
        //    {
        //        var cmbItem = new ComboBoxItem { Value = item.Id, Text = item.Token.ToString() };

        //        cmb.Items.Add(cmbItem);
        //    }

        //    return cmb;
        //}
        public async Task<ComboBox> GetVoters(ComboBox cmb)
        {
            var data = await _VoterAPIService.Get<List<VoterDTO>>(null);

            foreach (var item in data)
            {
                var cmbItem = new ComboBoxItem { Value = item.Id, Text = item.User.FirstName+item.User.LastName };

                cmb.Items.Add(cmbItem);
            }

            return cmb;
        }

    }
}
