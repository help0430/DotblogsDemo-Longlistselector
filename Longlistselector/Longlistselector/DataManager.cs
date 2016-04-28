using Longlistselector.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Longlistselector {
    public class DataManager {
        public static ObservableCollection<AccountItem> DataList { get; set; } = new ObservableCollection<AccountItem> {
            new AccountItem { Name="Tom", Score = 10 },
            new AccountItem { Name="Help", Score = 11 },
            new AccountItem { Name="Eric", Score = 3 },
            new AccountItem { Name="Emma", Score = 4 },
            new AccountItem { Name="Jack", Score = 8 },
            new AccountItem { Name="Coco", Score = 14 },
            new AccountItem { Name="Joe", Score = 2 },
            new AccountItem { Name="Eva", Score = 8 },
            new AccountItem { Name="May", Score = 9 },
            new AccountItem { Name="Cindy", Score = 4 },
            new AccountItem { Name="Wei", Score = 14 },
        };

        public ObservableCollection<IGrouping<string, AccountItem>> AlphaGroups { get; set; }

        public DataManager() {
            var list = from f in DataList
                       group f by f.Name[0].ToString() into g
                       orderby g.Key
                       select g;
            AlphaGroups = new ObservableCollection<IGrouping<string, AccountItem>>(list);
        }
    }
}
