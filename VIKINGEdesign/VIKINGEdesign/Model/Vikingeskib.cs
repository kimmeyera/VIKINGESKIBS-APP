﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using VIKINGEdesign.Annotations;

namespace VIKINGEdesign.Model
{
    class Vikingeskib : INotifyPropertyChanged
    {
        private int _skibsId;
        private string _navn;
        private int _pladser;
        private string _beskrivelse;
        private string _informationer;
        private string _billede;

        public Vikingeskib(int skibsId, string navn, int pladser, string beskrivelse, string informationer, string billede)
        {
            _skibsId = skibsId;
            _navn = navn;
            _pladser = pladser;
            _beskrivelse = beskrivelse;
            _informationer = informationer;
            _billede = billede;
        }

        public int VikingeSkibeID
        {
            get { return _skibsId; }
            set { _skibsId = value; }
        }

        public string Name
        {
            get { return _navn; }
            set { _navn = value; }
        }

        public int AntalPladser
        {
            get { return _pladser; }
            set { _pladser = value; }
        }

        public string Beskrivelse
        {
            get { return _beskrivelse; }
            set { _beskrivelse = value; }
        }

        public string YderligereInformationer
        {
            get { return _informationer; }
            set { _informationer = value; }
        }

        public string Billede
        {
            get { return _billede; }
            set { _billede = value; }
        }
        public override string ToString()
        {
            return string.Format(_navn);
        }

        #region PropertyChanged

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion

    }
}
