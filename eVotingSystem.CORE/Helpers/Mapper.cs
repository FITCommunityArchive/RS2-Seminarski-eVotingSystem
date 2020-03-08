using AutoMapper;
using eVotingSystem.CORE.Models;
using eVotingSystem.CORE.Requests;

namespace eVotingSystem.CORE.Helpers
{
    public class Mapper : Profile
    {
        public Mapper()
        {

            CreateMap<Candidate, CandidateDTO>();
            CreateMap<CandidateRequest, Candidate>();
            CreateMap<CandidateRequest, CandidateDTO>();

            CreateMap<City, CityDTO>();
            CreateMap<CityRequest, City>();
            CreateMap<CityRequest, CityDTO>();

            CreateMap<Country, CountryDTO>();
            CreateMap<CountryRequest, Country>();
            CreateMap<CountryRequest, CountryDTO>();

            CreateMap<ElectionCycle, ElectionCycleDTO>();
            CreateMap<ElectionCycleRequest, ElectionCycle>();
            CreateMap<ElectionCycleRequest, ElectionCycleDTO>();

            CreateMap<ElectionCycleElectiveList, ElectionCycleElectiveListDTO>();
            CreateMap<ElectionCycleElectiveListRequest, ElectionCycleElectiveList>();
            CreateMap<ElectionCycleElectiveListRequest, ElectionCycleElectiveListDTO>();


            CreateMap<ElectionOption, ElectionOptionDTO>();
            CreateMap<ElectionOptionRequest, ElectionOption>();
            CreateMap<ElectionOptionRequest, ElectionOptionDTO>();

            CreateMap<ElectionRegion, ElectionRegionDTO>();
            CreateMap<ElectionRegionRequest, ElectionRegion>();
            CreateMap<ElectionRegionRequest, ElectionRegionDTO>();

            CreateMap<ElectionUnit, ElectionUnitDTO>();
            CreateMap<ElectionUnitRequest, ElectionUnit>();
            CreateMap<ElectionUnitRequest, ElectionUnitDTO>();

            CreateMap<ElectiveList, ElectiveListDTO>();
            CreateMap<ElectiveListRequest, ElectiveList>();
            CreateMap<ElectiveListRequest, ElectiveListDTO>();

            CreateMap<ElectiveListElectionOption, ElectiveListElectionOptionDTO>();
            CreateMap<ElectiveListElectionOptionRequest, ElectiveListElectionOption>();
            CreateMap<ElectiveListElectionOptionRequest, ElectiveListElectionOptionDTO>();

            CreateMap<File, FileDTO>();
            CreateMap<FileRequest, File>();
            CreateMap<FileRequest, FileDTO>();
            
            CreateMap<Message,MessageDTO>();
            CreateMap<MessageRequest, Message>();
            CreateMap<MessageRequest, MessageDTO>();
            
            CreateMap<Nationality, NationalityDTO>();
            CreateMap<NationalityRequest, Nationality>();
            CreateMap<NationalityRequest, NationalityDTO>();
            
            CreateMap<PoliticalOrganization, PoliticalOrganizationDTO>();
            CreateMap<PoliticalOrganizationRequest, PoliticalOrganization>();
            CreateMap<PoliticalOrganizationRequest, PoliticalOrganizationDTO>();
            
            CreateMap<User, UserDTO>();
            CreateMap<UserRequest, User>();
            CreateMap<UserRequest, UserDTO>();
            
            CreateMap<Vote, VoteDTO>();
            CreateMap<VoteRequest, Vote>();
            CreateMap<VoteRequest, VoteDTO>();
            
            CreateMap<Voter, VoterDTO>();
            CreateMap<VoterRequest, Voter>();
            CreateMap<VoterRequest, VoterDTO>();


        }
    }
}
