using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlPanel.Models
{
    class ControlPanelItem : DomainObject
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; this.RaisePropertyChanged("Name"); }
        }

        private string description;
        public string Description
        {
            get { return description; }
            set { description = value; this.RaisePropertyChanged("Description"); }
        }
    }
}