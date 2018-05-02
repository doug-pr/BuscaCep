﻿using BuscaCep.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BuscaCep.Pages
{

	public partial class BuscaCepPage : ContentPage
	{
		public BuscaCepPage ()
		{
			InitializeComponent ();

            BindingContext = new BuscaCepViewModel() { CEP = "87204064"};
		}
	}
}