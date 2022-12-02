using FuturumCampaign.Commands;
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
        private decimal amount;
        private Campaign campaign;

        private decimal fund;

        private string keyword;
        private List<string> keywords = new();
        private decimal minAmount;
        private string name;

        private string status;
        private List<string> statusList = new();
        private List<string> townsList = new();
        private string town;
        private double radius;
        private List<string> allKeywords = new();

        public ICommand AddKeywordCommand { get; set; }
        public ICommand SaveNewCampaignCommand { get; set; }

        public NewCampaignVM()
        {
            Campaign = new Campaign();
            AllKeywords = KeywordsCreator.CreateKeywords();
            TownsList = TownsCreator.CreateTowns();
            AddKeywordCommand = new AddKeywordCommand(this);
            SaveNewCampaignCommand = new SaveNewCampaignCommand(this);
        }

        public decimal Amount
        {
            get { return amount; }
            set { amount = value; OnPropertyChanged(); }
        }

        public Campaign Campaign
        {
            get { return campaign; }
            set { campaign = value; OnPropertyChanged(); }
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

        public string Status
        {
            get { return status; }
            set { status = value; OnPropertyChanged(); }
        }

        private static List<string> GetStatusList()
        {
            return Enum.GetValues(typeof(Status.Values))
                       .Cast<Status.Values>()
                       .Select(v => v.ToString())
                       .ToList();
        }
        public List<string> StatusList
        {
            get { return GetStatusList(); }
            set { statusList = value; OnPropertyChanged(); }
        }
        public List<string> TownsList
        {
            get { return townsList; }
            set { townsList = value; OnPropertyChanged(); }
        }

        public string Town
        {
            get { return town; }
            set { town = value; OnPropertyChanged(); }
        }
        public double Radius
        {
            get { return radius; } 
            set { radius = value; OnPropertyChanged(); }
        }

        public List<string> AllKeywords
        {
            get { return allKeywords; }
            set { allKeywords = value; OnPropertyChanged(); }
        }
    }
}