using System;
using System.Collections.Generic;
using System.Text;

namespace eVotingSystem.Mobile.Models
{
    public enum MenuItemType
    {
        Votes,
        Messages,
        Settings,
        Documents
    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }
    }
}
