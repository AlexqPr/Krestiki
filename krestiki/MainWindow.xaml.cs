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

namespace krestiki
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int krest = 0;
        private int mayak2 = 0;

      
        public MainWindow()
        {
            InitializeComponent();
        }

    
        private void startgame_Click(object sender, RoutedEventArgs e)
        {
           mayak2 = 0;
           message.Content = "Крестики-нолики";
           button1.Content = " ";
           button2.Content = " ";
           button3.Content = " ";
           button4.Content = " ";
           button5.Content = " ";
           button6.Content = " ";
           button7.Content = " ";
           button8.Content = " ";
           button9.Content = " ";
           button1.IsEnabled = true;
           button2.IsEnabled = true;
           button3.IsEnabled = true;
           button4.IsEnabled = true;
           button5.IsEnabled = true;
           button6.IsEnabled = true;
           button7.IsEnabled = true;
           button8.IsEnabled = true;
           button9.IsEnabled = true;


        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            Checked(sender);
            (sender as Button).IsEnabled = false;
            if(krest == 0)
            {
                (sender as Button).Content = "x";
                mayak2++;

            }
            else
            {
                (sender as Button).Content = "o";
                mayak2++;

            }
            //Checked(sender);
            if(mayak2 == 5)
            {
                message.Content = "Ничья";
                zanovo();
            }
            Robot(sender);
        }
        private void zanovo()
        {
            
            button1.IsEnabled = false;
            
            button2.IsEnabled = false;
            
            button3.IsEnabled = false;
            
            button4.IsEnabled = false;
           
            button5.IsEnabled = false;
          
            button6.IsEnabled = false;
            
            button7.IsEnabled = false;
            
            button8.IsEnabled = false;
          
            button9.IsEnabled = false;

            if(krest == 1)
            {
                krest = 0;
            }
            else
            {
                krest = 1;
            }
            
        }
        private void Checked(object sender)
        {
            if (button1.Content == "x" && button2.Content == "x" && button3.Content == "x")
            {
                zanovo();
                message.Content = "Крестики выиграли";
            }
            else if(button4.Content == "x" && button5.Content == "x" && button6.Content == "x")
            {
                zanovo();
                message.Content = "Крестики выиграли";
            }
            else if (button7.Content == "x" && button8.Content == "x" && button9.Content == "x")
            {
                zanovo();
                message.Content = "Крестики выиграли";
            }
            else if (button1.Content == "x" && button4.Content == "x" && button7.Content == "x")
            {
                zanovo();
                message.Content = "Крестики выиграли";
            }
            else if (button2.Content == "x" && button5.Content == "x" && button8.Content == "x")
            {
                zanovo();
                message.Content = "Крестики выиграли";
            }
            else if (button3.Content == "x" && button6.Content == "x" && button9.Content == "x")
            {
                zanovo();
                message.Content = "Крестики выиграли";
            }
            else if (button1.Content == "x" && button5.Content == "x" && button9.Content == "x")
            {
                zanovo();
                message.Content = "Крестики выиграли";
            }
            else if (button7.Content == "x" && button5.Content == "x" && button3.Content == "x")
            {
                zanovo();
                message.Content = "Крестики выиграли";
            }
            else if (button1.Content == "o" && button2.Content == "o" && button3.Content == "o")
            {
                zanovo();
                message.Content = "Нолики выиграли";

            }
            else if (button4.Content == "o" && button5.Content == "o" && button6.Content == "o")
            {
                zanovo();
                message.Content = "Нолики выиграли";
            }
            else if (button7.Content == "o" && button8.Content == "o" && button9.Content == "o")
            {
                zanovo();
                message.Content = "Нолики выиграли";
            }
            else if (button1.Content == "o" && button4.Content == "o" && button7.Content == "o")
            {
                zanovo();
                message.Content = "Нолики выиграли";
            }
            else if (button2.Content == "o" && button5.Content == "o" && button8.Content == "o")
            {
                zanovo();
                message.Content = "Нолики выиграли";
            }
            else if (button3.Content == "o" && button6.Content == "o" && button9.Content == "o")
            {
                zanovo();
                message.Content = "Нолики выиграли";
            }
            else if (button1.Content == "o" && button5.Content == "o" && button9.Content == "o")
            {
                zanovo();
                message.Content = "Нолики выиграли";
            }
            else if (button7.Content == "o" && button5.Content == "o" && button3.Content == "o")
            {
                zanovo();
                message.Content = "Нолики выиграли";
            }
            
           
           
            

        }
        private void Robot(object sender)//логика робота
        {
            Random rand = new Random();
            int newrand;
            if(mayak2 < 5)
            {
                if (krest == 1) //крестики
                {
                    int mayak = 0;
                    newrand = rand.Next(1, 10);
                    while (mayak == 0)
                    {
                        switch (newrand)
                        {
                            case 1:
                                if (button1.Content == " ")
                                {
                                    button1.Content = "x";
                                    button1.IsEnabled = false;
                                    mayak = 1;
                                }
                                break;
                            case 2:
                                if (button2.Content == " ")
                                {
                                    button2.Content = "x";
                                    button2.IsEnabled = false;
                                    mayak = 1;
                                }
                                break;
                            case 3:
                                if (button3.Content == " ")
                                {
                                    button3.Content = "x";
                                    button3.IsEnabled = false;
                                    mayak = 1;
                                }
                                break;
                            case 4:
                                if (button4.Content == " ")
                                {
                                    button4.Content = "x";
                                    button4.IsEnabled = false;
                                    mayak = 1;
                                }
                                break;
                            case 5:
                                if (button5.Content == " ")
                                {
                                    button5.Content = "x";
                                    button5.IsEnabled = false;
                                    mayak = 1;
                                }
                                break;
                            case 6:
                                if (button6.Content == " ")
                                {
                                    button6.Content = "x";
                                    button6.IsEnabled = false;
                                    mayak = 1;
                                }
                                break;
                            case 7:
                                if (button7.Content == " ")
                                {
                                    button7.Content = "x";
                                    button7.IsEnabled = false;
                                    mayak = 1;
                                }
                                break;
                            case 8:
                                if (button8.Content == " ")
                                {
                                    button8.Content = "x";
                                    button8.IsEnabled = false;
                                    mayak = 1;
                                }
                                break;
                            case 9:
                                if (button9.Content == " ")
                                {
                                    button9.Content = "x";
                                    button9.IsEnabled = false;
                                    mayak = 1;
                                }
                                break;
                        }
                        newrand = rand.Next(1, 10);
                    }
                }
                else //нолики
                {
                    int mayak = 0;
                    newrand = rand.Next(1, 10);
                    while (mayak == 0)
                    {
                        switch (newrand)
                        {
                            case 1:
                                if (button1.Content == " ")
                                {
                                    button1.Content = "o";
                                    button1.IsEnabled = false;
                                    mayak = 1;
                                }
                                break;
                            case 2:
                                if (button2.Content == " ")
                                {
                                    button2.Content = "o";
                                    button2.IsEnabled = false;
                                    mayak = 1;
                                }
                                break;
                            case 3:
                                if (button3.Content == " ")
                                {
                                    button3.Content = "o";
                                    button3.IsEnabled = false;
                                    mayak = 1;
                                }
                                break;
                            case 4:
                                if (button4.Content == " ")
                                {
                                    button4.Content = "o";
                                    button4.IsEnabled = false;
                                    mayak = 1;
                                }
                                break;
                            case 5:
                                if (button5.Content == " ")
                                {
                                    button5.Content = "o";
                                    button5.IsEnabled = false;
                                    mayak = 1;
                                }
                                break;
                            case 6:
                                if (button6.Content == " ")
                                {
                                    button6.Content = "o";
                                    button6.IsEnabled = false;
                                    mayak = 1;
                                }
                                break;
                            case 7:
                                if (button7.Content == " ")
                                {
                                    button7.Content = "o";
                                    button7.IsEnabled = false;
                                    mayak = 1;
                                }
                                break;
                            case 8:
                                if (button8.Content == " ")
                                {
                                    button8.Content = "o";
                                    button8.IsEnabled = false;
                                    mayak = 1;
                                }
                                break;
                            case 9:
                                if (button9.Content == " ")
                                {
                                    button9.Content = "o";
                                    button9.IsEnabled = false;
                                    mayak = 1;
                                }
                                break;
                        }
                        newrand = rand.Next(1, 10);
                    }



                }
            }

            Checked(sender);
        }
    }
}
