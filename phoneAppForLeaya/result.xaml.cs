using electrocalculator.Analysis;
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
    public sealed partial class result : Page
    {
        public result()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Вызывается перед отображением этой страницы во фрейме.
        /// </summary>
        /// <param name="e">Данные события, описывающие, каким образом была достигнута эта страница.
        /// Этот параметр обычно используется для настройки страницы.</param>
        components component;
        List<double> Rvalues = new List<double>();
        List<int> RPvalues = new List<int>();
        List<int> RNvalues = new List<int>();

        List<double> Cvalues = new List<double>();
        List<int> CPvalues = new List<int>();
        List<int> CNvalues = new List<int>();

        List<double> Ivalues = new List<double>();
        List<int> IPvalues = new List<int>();
        List<int> INvalues = new List<int>();
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            component = (components)e.Parameter;
            LocalAnalysis local_analysis = new LocalAnalysis();
            inputesToArray();

            local_analysis.Node = component.Node;

            resistorComp Resistor = new resistorComp();
            Resistor.ResistorsValue = Rvalues;
            Resistor.ResistorsPositiveNodes = RPvalues;
            Resistor.ResistorsNegativeNodes = RNvalues;
            local_analysis.Resistor = Resistor;

            capacitorComp Capacitor = new capacitorComp();
            Capacitor.CapacitorsValue = Cvalues;
            Capacitor.CapacitorsPositiveNodes = CPvalues;
            Capacitor.CapacitorsNegativeNodes = CNvalues;
            local_analysis.Capacitor = Capacitor;

            inductorComp Inductor = new inductorComp();
            Inductor.IductorsValue= Ivalues;
            Inductor.IductorsPositiveNodes = IPvalues;
            Inductor.IductorsNegativeNodes = INvalues;
            local_analysis.Inductor = Inductor;

            local_analysis.AnalysisTheCircute();

            int kp = component.outputpositive;
            int km = component.outputnegative;

            double[] result = local_analysis.Answer(kp, km);


            Grid grdResult = new Grid();
            for (int i = 0; i < result.Length; i++)
            {
                grdResult.RowDefinitions.Add(new RowDefinition());
            }

            for (int i = 0; i < 1; i++)
            {
                grdResult.ColumnDefinitions.Add(new ColumnDefinition());
            }

            for (int x = 0; x <result.Length; x++)
            {
                //for (int y = 0; y <1; y++)
                //{
                TextBlock t = new TextBlock();
                t.SetValue(Grid.RowProperty, x);
                t.SetValue(Grid.ColumnProperty, 0);
                t.Text = result[x].ToString();
                t.VerticalAlignment = Windows.UI.Xaml.VerticalAlignment.Center;
                t.HorizontalAlignment = Windows.UI.Xaml.HorizontalAlignment.Center;
                t.FontSize = 25;
                grdResult.Children.Add(t);
                // }
            }
            firstPlace.Children.Add(grdResult);


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
            Frame.Navigate(typeof(MainPage));
        }


        private void inputesToArray()
        {
            if (component.resistor!=0)
            { 
                        Grid gridR = (Grid)component.resistorValues;
                        foreach (TextBox textb in gridR.Children)
                        {
                            Rvalues.Add(Convert.ToDouble(textb.Text));
                        }

                        Grid gridRP = (Grid)component.resistorNPValues;
                        foreach (TextBox textb in gridRP.Children)
                        {
                            RPvalues.Add(Convert.ToInt16(textb.Text));
                        }


                        Grid gridRN = (Grid)component.resistorNNValues;
                        foreach (TextBox textb in gridRN.Children)
                        {
                            RNvalues.Add(Convert.ToInt16(textb.Text));
                        }

            }


            if (component.capacitor != 0)
            {
                Grid gridC = (Grid)component.capacitorValues;
                foreach (TextBox textb in gridC.Children)
                {
                    Cvalues.Add(Convert.ToDouble(textb.Text));
                }

                Grid gridCP = (Grid)component.capacitorNPValues;
                foreach (TextBox textb in gridCP.Children)
                {
                    CPvalues.Add(Convert.ToInt16(textb.Text));
                }


                Grid gridCN = (Grid)component.capacitorNNValues;
                foreach (TextBox textb in gridCN.Children)
                {
                    CNvalues.Add(Convert.ToInt16(textb.Text));
                }


            }


            if (component.Iductor != 0)
            {
                Grid gridI = (Grid)component.inductorValues;
                foreach (TextBox textb in gridI.Children)
                {
                    Ivalues.Add(Convert.ToDouble(textb.Text));
                }

                Grid gridIP = (Grid)component.inductorNPValues;
                foreach (TextBox textb in gridIP.Children)
                {
                    IPvalues.Add(Convert.ToInt16(textb.Text));
                }


                Grid gridIN = (Grid)component.inductorNNValues;
                foreach (TextBox textb in gridIN.Children)
                {
                    INvalues.Add(Convert.ToInt16(textb.Text));
                }
            }


            }

    }
}
