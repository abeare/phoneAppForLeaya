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
    public sealed partial class resistor : Page
    {
        public resistor()
        {
            this.InitializeComponent();



           
        }

        /// <summary>
        /// Вызывается перед отображением этой страницы во фрейме.
        /// </summary>
        /// <param name="e">Данные события, описывающие, каким образом была достигнута эта страница.
        /// Этот параметр обычно используется для настройки страницы.</param>
        ///  components component

        components component;

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            component = (components)e.Parameter;
            int node= component.Node;
            int v = component.resistor;
            Grid grdR = new Grid();
            for (int i = 0; i < v; i++)
            {
                grdR.RowDefinitions.Add(new RowDefinition());
            }

            for (int i = 0; i < 1; i++)
            {
                grdR.ColumnDefinitions.Add(new ColumnDefinition());
            }

            for (int x = 0; x < v; x++)
            {
                //for (int y = 0; y <1; y++)
                //{
                    TextBlock t = new TextBlock();
                    t.SetValue(Grid.RowProperty, x);
                    t.SetValue(Grid.ColumnProperty, 0);
                    t.Text = "Resistor - " + (x+1).ToString();
                    t.VerticalAlignment = Windows.UI.Xaml.VerticalAlignment.Center;
                    t.HorizontalAlignment = Windows.UI.Xaml.HorizontalAlignment.Center;
                    t.FontSize =25;
                    grdR.Children.Add(t);
               // }
            }
            firstPlace.Children.Add(grdR);

            Grid grdR2 = new Grid();
            for (int i = 0; i < v; i++)
            {
                grdR2.RowDefinitions.Add(new RowDefinition());
            }

            for (int i = 0; i < 1; i++)
            {
                grdR2.ColumnDefinitions.Add(new ColumnDefinition());
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
                    t.Name = "R" + x.ToString();
                
                t.VerticalAlignment = Windows.UI.Xaml.VerticalAlignment.Center;
                    t.HorizontalAlignment = Windows.UI.Xaml.HorizontalAlignment.Stretch;
                    t.InputScope = inputscope;
                    grdR2.Children.Add(t);
                //}
            }
            secoundPlace.Children.Add(grdR2);
            component.resistorValues = grdR2;
            //Positive combobox value


            Grid grdRNP3 = new Grid();
            for (int i = 0; i < v; i++)
            {
                grdRNP3.RowDefinitions.Add(new RowDefinition());
            }
            for (int i = 0; i < 1; i++)
            {
                grdRNP3.ColumnDefinitions.Add(new ColumnDefinition());
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
                t.Name = "RP" + x.ToString();
                t.Text = x.ToString();
                t.VerticalAlignment = Windows.UI.Xaml.VerticalAlignment.Center;
                t.HorizontalAlignment = Windows.UI.Xaml.HorizontalAlignment.Stretch;
                t.InputScope = inputscope;
                grdRNP3.Children.Add(t);

            }
            thirdPlace.Children.Add(grdRNP3);

            component.resistorNPValues = grdRNP3;

            //campobox Negative

            Grid grdRNN4 = new Grid();
            for (int i = 0; i < v; i++)
            {
                grdRNN4.RowDefinitions.Add(new RowDefinition());
            }
            for (int i = 0; i < 1; i++)
            {
                grdRNN4.ColumnDefinitions.Add(new ColumnDefinition());
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
                t.Name = "RN" + x.ToString();
                t.Text = x.ToString();
                t.VerticalAlignment = Windows.UI.Xaml.VerticalAlignment.Center;
                t.HorizontalAlignment = Windows.UI.Xaml.HorizontalAlignment.Stretch;
                t.InputScope = inputscope;
               
                grdRNN4.Children.Add(t);

            }
            fourthPlace.Children.Add(grdRNN4);

            component.resistorNNValues = grdRNN4;


            Button btn = new Button();
            {

                btn.Name = "button";
                btn.Height = 20;
                btn.Width = 50;
                btn.Foreground = new SolidColorBrush(Windows.UI.Colors.Black);
                btn.Content = "Next";

                btn.Margin = new Thickness(5 , 5, 5, 5);
                btn.VerticalAlignment = Windows.UI.Xaml.VerticalAlignment.Bottom;
                btn.HorizontalAlignment = Windows.UI.Xaml.HorizontalAlignment.Center;
            }
            //Add Click event Handler for each created button
            btn.Click += button_Click;
          mainPlace.Children.Add(btn);
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            if (component.capacitor != 0)
                Frame.Navigate(typeof(capacitor), component);
            else if (component.Iductor != 0)
                Frame.Navigate(typeof(inductor), component);
            else
                Frame.Navigate(typeof(result),component);
        }

        private void GridView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
