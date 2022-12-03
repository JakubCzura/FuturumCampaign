using FuturumCampaign.Commands;
using FuturumCampaign.DataHelper;
using FuturumCampaign.DirectoriesHelper;
using FuturumCampaign.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Input;

namespace FuturumCampaign.ViewModels
{
    /// <summary>
    /// View Model for NewCampaignUC
    /// </summary>
    public class NewCampaignVM : BaseViewModel
    {
        private List<string> allKeywords = new();
        private decimal bidAmount;


        private List<Campaign> campaigns = new();
        private decimal fund;

        private string keyword;
        private List<string> keywords = new();
        private decimal minAmount;
        private string name;

        private double radius;
        private string status;
        private List<string> statusList = new();
        private string town;
        private List<string> townsList = new();
        public NewCampaignVM()
        {
            Campaigns = CampaignsData.ReadCampaigns();

            AllKeywords = KeywordsCreator.CreateKeywords();
            TownsList = TownsCreator.CreateTowns();
            StatusList = GetStatusList();
            AddKeywordCommand = new AddKeywordCommand(this);
            SaveNewCampaignCommand = new SaveNewCampaignCommand(this);
            ApplicationDirectories.CreateDataDirectory();
        }

        public ICommand AddKeywordCommand { get; set; }
        public List<string> AllKeywords
        {
            get { return allKeywords; }
            set { allKeywords = value; OnPropertyChanged(); }
        }

        public decimal BidAmount
        {
            get { return bidAmount; }
            set { bidAmount = value; OnPropertyChanged(); }
        }

        public List<Campaign> Campaigns
        {
            get { return campaigns; }
            set { campaigns = value; OnPropertyChanged(); }
        }

        public decimal Fund
        {
            get { return fund; }
            set { fund = value; OnPropertyChanged(); }
        }

        public string Keyword
        {
            get { return keyword; }
            set { keyword = value; OnPropertyChanged(); }
        }

        public List<string> Keywords
        {
            get { return keywords; }
            set { keywords = value; OnPropertyChanged(); }
        }

        public decimal MinAmount
        {
            get { return minAmount; }
            set { minAmount = value; OnPropertyChanged(); }
        }

        public string Name
        {
            get { return name; }
            set { name = value; OnPropertyChanged(); }
        }

        public double Radius
        {
            get { return radius; }
            set { radius = value; OnPropertyChanged(); }
        }

        public ICommand SaveNewCampaignCommand { get; set; }
        public string Status
        {
            get { return status; }
            set { status = value; OnPropertyChanged(); }
        }

        public List<string> StatusList
        {
            get { return statusList; }
            set { statusList = value; OnPropertyChanged(); }
        }

        public string Town
        {
            get { return town; }
            set { town = value; OnPropertyChanged(); }
        }

        public List<string> TownsList
        {
            get { return townsList; }
            set { townsList = value; OnPropertyChanged(); }
        }

        public static List<string> GetStatusList()
        {
            return Enum.GetValues(typeof(Status.Values))
                       .Cast<Status.Values>()
                       .Select(v => v.ToString())
                       .ToList();
        }
    }
}