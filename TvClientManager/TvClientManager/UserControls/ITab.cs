using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TvClientManager.UserControls
{
    public interface ITab
    {
        TabState State
        { get; set; }

        void OnLoad();

        void OnChange();

        bool Save();

        void Cancel();

        void SetReadOnly(bool isReadOnly);

    }

    public enum TabState
    {
        Edit,
        ReadOnly
    }
}
