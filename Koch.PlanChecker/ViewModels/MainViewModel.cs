﻿using ESAPIX.Common;
using Prism.Mvvm;
using System.Linq;
using VMS.TPS.Common.Model.API;

namespace Koch.PlanChecker.ViewModels
{
    public class MainViewModel : BindableBase
    {
        AppComThread VMS = AppComThread.Instance;

        public MainViewModel()
        {
            
        }

        public void OnPlanChanged(PlanSetup ps)
        {
            //Must operate on VMS thread for plan access
            VMS.Invoke(() =>
            {
                Id = ps?.Id;
                UID = ps?.UID;
                IsDoseCalculated = ps?.Dose != null;
                NBeams = ps?.Beams.Count();
            });
        }

        private string id;

        public string Id
        {
            get { return id; }
            set { SetProperty(ref id, value); }
        }

        private string uid;

        public string UID
        {
            get { return uid; }
            set { SetProperty(ref uid, value); }
        }

        private int? nBeams;

        public int? NBeams
        {
            get { return nBeams; }
            set { SetProperty(ref nBeams, value); }
        }

        private bool isDoseCalculated;

        public bool IsDoseCalculated
        {
            get { return isDoseCalculated; }
            set { SetProperty(ref isDoseCalculated, value); }
        }
    }
}
