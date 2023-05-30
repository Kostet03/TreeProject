using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
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
using TreeProject.Models;

namespace TreeProject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public Node CreateNode(int maxDepth, int childrensCount)
        {
            var node = new Node
            {
                Key = Guid.NewGuid(),
                Name = $"Level {maxDepth}",
                Nodes = new List<Node>()
            };

            if (maxDepth > 0)
            {
                for (var i = 0; i < childrensCount; ++i)
                {
                    node.Nodes.Add(CreateNode(maxDepth - 1, childrensCount));
                }
            }

            return node;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int.TryParse(MaxLevelTextBox.Text, out var maxDepth);
            int.TryParse(ChildrensCountTextBox.Text, out var childrensCount);

            if (maxDepth > 0 && maxDepth <= 10 && childrensCount > 0 && childrensCount <= 5)
            {
                var itemsSource = new List<Node>();
                itemsSource.Add(CreateNode(maxDepth, childrensCount));
                Tree.ItemsSource = itemsSource;
                Log($"Успешная генерация дерева с количеством уровней: {maxDepth}");
            }
            else
            {
                MessageBox.Show("Некорректное заполнение глубины дерева. Пожалуйста, проверьте данные и повторите еще раз.");
                Log("Некорректное заполнение глубины дерева. Пожалуйста, проверьте данные и повторите еще раз.");
            }
        }

        public void Log(string message)
        {
            using (StreamWriter sw = new StreamWriter(System.IO.Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\log.txt", true))
            {
                sw.WriteLine(String.Format("{0,-23} {1}", DateTime.Now.ToString() + ":", message));
            }
        }
    }
}
