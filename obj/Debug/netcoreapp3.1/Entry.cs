using System;
using System.Collections.Generic;
using System.Text;

namespace InitiativeTracker.obj.Debug.netcoreapp3._1{
    public class Entry{
        //properties due to dynamic nature of data.
        public string Name { get; set; }
        public int Initiative { get; set; }
        public string Notes { get; set; }
        public int MaxHP { get; set; }
        public int CurrHP { get; set; }
        public int AC { get; set; }
        public int DeathSaveFails { get; set; }
        public int DeathSaveSucc { get; set; }


        //constructors
        public Entry() { //really don't think we will need anything other than the default.
            Name = "";
            Notes = "";
            MaxHP = 0;
            CurrHP = 0;
            AC = 0;
            DeathSaveFails = 0;
            DeathSaveSucc = 0;
        }
    }
}
