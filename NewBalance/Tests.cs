using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;
using System.Threading;

namespace NewBalance
{
	[TestFixture(Platform.Android)]
	[TestFixture(Platform.iOS)]
	public class Tests
	{
		IApp app;
		Platform platform;

		public Tests(Platform platform)
		{
			this.platform = platform;
		}

		[SetUp]
		public void BeforeEachTest()
		{
			app = AppInitializer.StartApp(platform);
		}

		[Test]
		public void Repl()
		{
			app.Repl();
		}

		[Test]
		public void SignUpTest()
		{
			app.Tap("button_signup");
			app.Screenshot("Let's start by Tapping on the 'Sign Up' Button");

			app.Tap("edit_first_name");
			app.Screenshot("Then we Tapped on the 'first name' Edit Text Field");
			app.EnterText("William");
			app.Screenshot("We entered our first name, William");
			app.DismissKeyboard();
			app.Screenshot("Dismissed Keyboard");

			app.Tap("edit_last_name");
			app.Screenshot("Then we Tapped on the 'last name' Edit Text Field");
			app.EnterText("Riley");
			app.Screenshot("We entered our last name, Riley");
			app.DismissKeyboard();
			app.Screenshot("Dismissed Keyboard");

			app.Tap("edit_email");
			app.Screenshot("Next we Tapped on the 'Edit Email' Field");
			app.EnterText("William.Riley@newbalance.com");
			app.Screenshot("We entered our E-Mail");
			app.DismissKeyboard();
			app.Screenshot("Dismissed Keyboard");

			app.Tap("edit_password");
			app.Screenshot("Then we Tapped on the 'Edit Password' Field");
			app.EnterText("newbalance");
			app.Screenshot("We entered our password, 'newbalance'");
			app.DismissKeyboard();
			app.Screenshot("Dismissed Keyboard");

			app.Tap("edit_confirm");
			app.Screenshot("Then we Tapped on the 'Confirm Password' Text Field");
			app.EnterText("newbalance");
			app.Screenshot("We confirmed our password, 'newbalance'");
			app.DismissKeyboard();
			app.Screenshot("Dismissed Keyboard");

			app.Tap("button_save_and_cont");
			app.Screenshot("Next, we Tapped on the 'Save' Button");

			app.Tap("NO THANKS");
			app.Screenshot("We Tapped 'No Thanks'");
		}

		[Test]
		public void SearchShoeTest()
		{
			app.Tap("button_login");
			app.Screenshot("We Tapped on the 'Login' Button");

			app.Tap("login_username");
			app.Screenshot("Then we Tapped on the 'username' Text");
			app.EnterText("William.Riley@newbalance.com");
			app.Screenshot("We entered our e-mail 'William.Riley@newbalance.com'");
			app.DismissKeyboard();
			app.Screenshot("Dismissed Keyboard");
			Thread.Sleep(15000);

			app.Tap("login_password");
			app.Screenshot("Next we Tapped on the 'Login Password' Text Field");
			app.EnterText("newbalance");
			app.Screenshot("We entered our password, 'newbalance'");
			app.DismissKeyboard();
			app.Screenshot("Dismissed Keyboard");
			Thread.Sleep(15000);

			app.Tap("button_login");
			app.Screenshot("Then we Tapped on the 'Sign In' Button");
			Thread.Sleep(15000);

			app.Tap("button_yes");
			app.Screenshot("Next, we Tapped the 'SHOP NOW' Button");

			app.Tap("action_search");
			app.Screenshot("We Tapped on the 'Search' Icon");

			app.EnterText("574");
			app.Screenshot("Then we typed in our favorite shoe style, '574'");

			app.PressEnter();
			app.Screenshot("We entered our search result");
		}

	}
}
