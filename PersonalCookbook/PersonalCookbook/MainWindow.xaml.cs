using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using PersonalCookbook.Bootstrapper;
using PersonalCookbook.Logic.Interfaces;
using PersonalCookbook.Models;

namespace PersonalCookbook
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private IRecipeRepository recipeRepository;

        public MainWindow()
        {
            InitializeComponent();

            // TODO [Alexander]: Use Factory and remove InternalsVisibleTo once the database is up and running
            recipeRepository = TestFactory.GetRecipeRepository();
            List<Recipe> recipes = recipeRepository.GetAllRecipes();
        }
    }
}
