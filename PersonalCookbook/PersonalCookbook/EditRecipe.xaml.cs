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
using System.Windows.Shapes;
using PersonalCookbook.Models;

namespace PersonalCookbook
{
    /// <summary>
    /// Interaction logic for EditRecipe.xaml
    /// </summary>
    public partial class EditRecipe : Window
    {
        public EditRecipe()
        {
            InitializeComponent();
        }

        public EditRecipe(Recipe recipe)
        {
            InitializeComponent();
            RecipeDetails.DataContext = recipe;
        }
    }
}
