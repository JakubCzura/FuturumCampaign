using FuturumCampaign.Commands;
using FuturumCampaign.DataHelper;
using FuturumCampaign.DirectoriesHelper;
using FuturumCampaign.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace FuturumCampaign.ViewModels
{
    public class CampaignsVM : NewCampaignVM
    {
        //private decimal bidAmount;


        //private decimal fund;

        //private string keyword;
        //private List<string> keywords = new();
        //private decimal minAmount;
        //private string name;

        //private string status;
        //private List<string> statusList = new();
        //private List<string> townsList = new();
        //private string town;
        //private double radius;
        //private List<string> allKeywords = new();
        //private List<Campaign> campaigns = new();
        private Campaign selectedCampaign = new();

        public ICommand DeleteCampaignCommand { get; set; }
        //public ICommand SaveNewCampaignCommand { get; set; }

        private ObservableCollection<Campaign> campaigns = new ObservableCollection<Campaign>();

        public new ObservableCollection<Campaign> Campaigns
        {
            get { return campaigns; }
            set { campaigns = value; OnPropertyChanged(); }
        }

        public CampaignsVM()
        {
            //Campaigns = CampaignsData.ReadCampaigns();
            Campaigns = new ObservableCollection<Campaign>(CampaignsData.ReadCampaigns());
            //AllKeywords = KeywordsCreator.CreateKeywords();
            //TownsList = TownsCreator.CreateTowns();
            //StatusList = GetStatusList();
            DeleteCampaignCommand = new DeleteCampaignCommand(this);
            //SaveNewCampaignCommand = new SaveNewCampaignCommand(this);
            //ApplicationDirectories.CreateDataDirectory();
        }

        public Campaign SelectedCampaign
        {
            get { return selectedCampaign; }
            set { selectedCampaign = value; OnPropertyChanged(); }
        }

        private string GetKeywords()
        {
            string keywords = string.Empty;
            foreach (var item in Keywords)
            {
                keywords += $"{item} ";
            }
            return keywords;
        }
        public string ShowKeywords
        {
            get
            {
                return GetKeywords();
                throw new Exception();
            }    
        }
        //public decimal BidAmount
        //{
        //    get { return bidAmount; }
        //    set { bidAmount = value; OnPropertyChanged(); }
        //}



        //public decimal Fund
        //{
        //    get { return fund; }
        //    set { fund = value; OnPropertyChanged(); }
        //}

        //public string Keyword
        //{
        //    get { return keyword; }
        //    set { keyword = value; OnPropertyChanged(); }
        //}

        //public List<string> Keywords
        //{
        //    get { return keywords; }
        //    set { keywords = value; OnPropertyChanged(); }
        //}

        //public decimal MinAmount
        //{
        //    get { return minAmount; }
        //    set { minAmount = value; OnPropertyChanged(); }
        //}

        //public string Name
        //{
        //    get { return name; }
        //    set { name = value; OnPropertyChanged(); }
        //}

        //public string Status
        //{
        //    get { return status; }
        //    set { status = value; OnPropertyChanged(); }
        //}

        //private static List<string> GetStatusList()
        //{
        //    return Enum.GetValues(typeof(Status.Values))
        //               .Cast<Status.Values>()
        //               .Select(v => v.ToString())
        //               .ToList();
        //}

        //public List<string> StatusList
        //{
        //    get { return statusList; }
        //    set { statusList = value; OnPropertyChanged(); }
        //}

        //public List<string> TownsList
        //{
        //    get { return townsList; }
        //    set { townsList = value; OnPropertyChanged(); }
        //}

        //public string Town
        //{
        //    get { return town; }
        //    set { town = value; OnPropertyChanged(); }
        //}

        //public double Radius
        //{
        //    get { return radius; }
        //    set { radius = value; OnPropertyChanged(); }
        //}

        //public List<string> AllKeywords
        //{
        //    get { return allKeywords; }
        //    set { allKeywords = value; OnPropertyChanged(); }
        //}

        //public List<Campaign> Campaigns
        //{
        //    get { return campaigns; }
        //    set { campaigns = value; OnPropertyChanged(); }
        //}
    }
}
