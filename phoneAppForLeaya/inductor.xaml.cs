using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// Документацию по шаблону элемента пустой страницы см. по адресу http://go.microsoft.com/fwlink/?LinkID=390556

namespace phoneAppForLeaya
{
    /// <summary>
    /// Пустая страница, которую можно использовать саму по себе или для перехода внутри фрейма.
    /// </summary>
    public sealed partial class inductor : Page
    {
        public inductor()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Вызывается перед отображением этой страницы во фрейме.
        /// </summary>
        /// <param name="e">Данные события, описывающие, каким образом была достигнута эта страница.
        /// Этот параметр обычно используется для настройки страницы.</param>
        components component;
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            component = (components)e.Parameter;
            int node = component.Node;
            int v = component.Iductor;
            Grid grdI = new Grid();
            for (int i = 0; i < v; i++)
            {
                grdI.RowDefinitions.Add(new RowDefinition());
            }

            for (int i = 0; i < 1; i++)
            {
                grdI.ColumnDefinitions.Add(new ColumnDefinition());
            }

            for (int x = 0; x < v; x++)
            {
                //for (int y = 0; y <1; y++)
                //{
                TextBlock t = new TextBlock();
                t.SetValue(Grid.RowProperty, x);
                t.SetValue(Grid.ColumnProperty, 0);
                t.Text = "Inductor - " + (x + 1).ToString();
                t.VerticalAlignment = Windows.UI.Xaml.VerticalAlignment.Center;
                t.HorizontalAlignment = Windows.UI.Xaml.HorizontalAlignment.Center;
                t.FontSize = 25;
                grdI.Children.Add(t);
                // }
            }
            firstPlace.Children.Add(grdI);

            Grid grdI2 = new Grid();
            for (int i = 0; i < v; i++)
            {
                grdI2.RowDefinitions.Add(new RowDefinition());
            }

            for (int i = 0; i < 1; i++)
            {
                grdI2.ColumnDefinitions.Add(new ColumnDefinition());
            }

            for (int x = 0; x < v; x++)
            {
                //for (int y = 1; y <= 1; y++)
                //{
                InputScope inputscope = new InputScope();
                InputScopeName inputscopeName = new InputScopeName();
                inputscopeName.NameValue = InputScopeNameValue.Number;
                inputscope.Names.Add(inputscopeName);

                TextBox t = new TextBox();
                t.SetValue(Grid.RowProperty, x);
                t.SetValue(Grid.ColumnProperty, 0);
                t.Name = "I" + x.ToString();
                t.Text = x.ToString();
                t.VerticalAlignment = Windows.UI.Xaml.VerticalAlignment.Center;
                t.HorizontalAlignment = Windows.UI.Xaml.HorizontalAlignment.Stretch;
                t.InputScope = inputscope;
                grdI2.Children.Add(t);
                //}
            }
            secoundPlace.Children.Add(grdI2);
            component.inductorValues = grdI2;
            //Positive combobox value


            Grid grdINP3 = new Grid();
            for (int i = 0; i < v; i++)
            {
                grdINP3.RowDefinitions.Add(new RowDefinition());
            }
            for (int i = 0; i < 1; i++)
            {
                grdINP3.ColumnDefinitions.Add(new ColumnDefinition());
            }

            for (int x = 0; x < v; x++)
            {
                InputScope inputscope = new InputScope();
                InputScopeName inputscopeName = new InputScopeName();
                inputscopeName.NameValue = InputScopeNameValue.Number;
                inputscope.Names.Add(inputscopeName);

                TextBox t = new TextBox();
                t.SetValue(Grid.RowProperty, x);
                t.SetValue(Grid.ColumnProperty, 0);
                t.Name = "IP" + x.ToString();
               
                t.VerticalAlignment = Windows.UI.Xaml.VerticalAlignment.Center;
                t.HorizontalAlignment = Windows.UI.Xaml.HorizontalAlignment.Stretch;
                t.InputScope = inputscope;
                grdINP3.Children.Add(t);

            }
            thirdPlace.Children.Add(grdINP3);

            component.inductorNPValues = grdINP3;

            //campobox Negative

            Grid grdINN4 = new Grid();
            for (int i = 0; i < v; i++)
            {
                grdINN4.RowDefinitions.Add(new RowDefinition());
            }
            for (int i = 0; i < 1; i++)
            {
                grdINN4.ColumnDefinitions.Add(new ColumnDefinition());
            }

            for (int x = 0; x < v; x++)
            {

                InputScope inputscope = new InputScope();
                InputScopeName inputscopeName = new InputScopeName();
                inputscopeName.NameValue = InputScopeNameValue.Number;
                inputscope.Names.Add(inputscopeName);

                TextBox t = new TextBox();
                t.SetValue(Grid.RowProperty, x);
                t.SetValue(Grid.ColumnProperty, 0);
                t.Name = "IN" + x.ToString();
                
                t.VerticalAlignment = Windows.UI.Xaml.VerticalAlignment.Center;
                t.HorizontalAlignment = Windows.UI.Xaml.HorizontalAlignment.Stretch;
                t.InputScope = inputscope;

                grdINN4.Children.Add(t);

            }
            fourthPlace.Children.Add(grdINN4);

            component.inductorNNValues = grdINN4;


            Button btn = new Button();
            {

                btn.Name = "button";
                btn.Height = 20;
                btn.Width = 50;
                btn.Foreground = new SolidColorBrush(Windows.UI.Colors.Black);
                btn.Content = "Next";

                btn.Margin = new Thickness(5, 5, 5, 5);
                btn.VerticalAlignment = Windows.UI.Xaml.VerticalAlignment.Bottom;
                btn.HorizontalAlignment = Windows.UI.Xaml.HorizontalAlignment.Center;
            }
            //Add Click event Handler for each created button
            btn.Click += button_Click;
            mainPlace.Children.Add(btn);
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(result), component);
        }
    }
}
