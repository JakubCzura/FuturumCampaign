﻿using FuturumCampaign.Commands;
using FuturumCampaign.DataHelper;
using FuturumCampaign.DirectoriesHelper;
using FuturumCampaign.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;

namespace FuturumCampaign.ViewModels
{
    /// <summary>
    /// View Model for NewCampaignUC
    /// </summary>
    public class NewCampaignVM : BaseViewModel
    {
        private decimal bidAmount;
        private string description;
        private decimal fund;
        private string keyword;
        private decimal minAmount;
        private string name;
        private string productName;
        private double radius;
        private string selectedKeyword;
        private string status;
        private string town;
        private List<Campaign> campaigns = new();
        private List<string> townsNamesList = new();
        private List<string> statusList = new();
        private List<string> allKeywords = new();
        private ObservableCollection<string> keywords = new();
        public ICommand DeleteKeywordCommand { get; set; }
        public ICommand SaveNewCampaignCommand { get; set; }

        public NewCampaignVM()
        {
            Campaigns = CampaignsData.ReadCampaigns();
            AllKeywords = KeywordsNamesData.ReadKeywordsNames();
            TownsNamesList = TownsNamesData.ReadTownsNames();
            StatusList = GetStatusList();
            AddKeywordCommand = new AddKeywordCommand(this);
            SaveNewCampaignCommand = new SaveNewCampaignCommand(this);
            DeleteKeywordCommand = new DeleteKeywordCommand(this);
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

        public string Description
        {
            get { return description; }
            set { description = value; OnPropertyChanged(); }
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

        public ObservableCollection<string> Keywords
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

        public string ProductName
        {
            get { return productName; }
            set { productName = value; OnPropertyChanged(); }
        }

        public double Radius
        {
            get { return radius; }
            set { radius = value; OnPropertyChanged(); }
        }

        public string SelectedKeyword
        {
            get { return selectedKeyword; }
            set { selectedKeyword = value; OnPropertyChanged(); }
        }

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

        public List<string> TownsNamesList
        {
            get { return townsNamesList; }
            set { townsNamesList = value; OnPropertyChanged(); }
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