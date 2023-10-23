using Microsoft.Extensions.DependencyInjection;
using System;

namespace ScreenMelder
{
    public partial class ScreenMelder : Form
    {
        private readonly ServiceProvider _ServiceProvider;
        public ScreenMelder(ServiceProvider ServiceProvider)
        {
            _ServiceProvider = ServiceProvider;
            InitializeComponent();
        }
    }
}