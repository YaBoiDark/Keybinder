using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Windows.Input;

namespace Dark_Keybinder
{
	// Made by YaBoiDark#4646
	public partial class Form1 : MetroFramework.Forms.MetroForm
	{
		bool isRunning = true;
		bool isRunning2 = true;
		bool isRunning3 = true;
		bool isRunning4 = true;
		bool isRunning5 = true;
		bool isRunning6 = true;

		bool fast = false;
		bool fast2 = false;
		bool fast3 = false;
		bool fast4 = false;
		bool fast5 = false;
		bool fast6 = false;

		IWshRuntimeLibrary.WshShell shell = new IWshRuntimeLibrary.WshShell();

		[DllImport("user32.dll")]
		public static extern int SetForegroundWindow(IntPtr hWnd);

		public Form1()
		{
			InitializeComponent();

			metroComboBox1.DisplayMember = "Text";
			metroComboBox1.ValueMember = "Value";
			metroComboBox1.Items.Add(new { Text = "F1", Value = "90" });
			metroComboBox1.Items.Add(new { Text = "F2", Value = "91" });
			metroComboBox1.Items.Add(new { Text = "F3", Value = "92" });
			metroComboBox1.Items.Add(new { Text = "F4", Value = "93" });
			metroComboBox1.Items.Add(new { Text = "F5", Value = "94" });
			metroComboBox1.Items.Add(new { Text = "F6", Value = "95" });
			metroComboBox1.Items.Add(new { Text = "F7", Value = "96" });
			metroComboBox1.Items.Add(new { Text = "F8", Value = "97" });
			metroComboBox1.Items.Add(new { Text = "F9", Value = "98" });
			metroComboBox1.Items.Add(new { Text = "F10", Value = "99" });
			metroComboBox1.Items.Add(new { Text = "F11", Value = "100" });
			metroComboBox1.Items.Add(new { Text = "F12", Value = "101" });
			metroComboBox1.Items.Add(new { Text = "Left Shift", Value = "116" });
			metroComboBox1.Items.Add(new { Text = "Right Shift", Value = "117" });
			metroComboBox1.Items.Add(new { Text = "Left Ctrl", Value = "118" });
			metroComboBox1.Items.Add(new { Text = "Right Ctrl", Value = "119" });
			metroComboBox1.Items.Add(new { Text = "Left Alt", Value = "120" });
			metroComboBox1.Items.Add(new { Text = "Right Alt", Value = "121" });
			metroComboBox1.SelectedIndex = 0;

			metroComboBox2.DisplayMember = "Text";
			metroComboBox2.ValueMember = "Value";
			metroComboBox2.Items.Add(new { Text = "F1", Value = "90" });
			metroComboBox2.Items.Add(new { Text = "F2", Value = "91" });
			metroComboBox2.Items.Add(new { Text = "F3", Value = "92" });
			metroComboBox2.Items.Add(new { Text = "F4", Value = "93" });
			metroComboBox2.Items.Add(new { Text = "F5", Value = "94" });
			metroComboBox2.Items.Add(new { Text = "F6", Value = "95" });
			metroComboBox2.Items.Add(new { Text = "F7", Value = "96" });
			metroComboBox2.Items.Add(new { Text = "F8", Value = "97" });
			metroComboBox2.Items.Add(new { Text = "F9", Value = "98" });
			metroComboBox2.Items.Add(new { Text = "F10", Value = "99" });
			metroComboBox2.Items.Add(new { Text = "F11", Value = "100" });
			metroComboBox2.Items.Add(new { Text = "F12", Value = "101" });
			metroComboBox2.Items.Add(new { Text = "Left Shift", Value = "116" });
			metroComboBox2.Items.Add(new { Text = "Right Shift", Value = "117" });
			metroComboBox2.Items.Add(new { Text = "Left Ctrl", Value = "118" });
			metroComboBox2.Items.Add(new { Text = "Right Ctrl", Value = "119" });
			metroComboBox2.Items.Add(new { Text = "Left Alt", Value = "120" });
			metroComboBox2.Items.Add(new { Text = "Right Alt", Value = "121" });
			metroComboBox2.SelectedIndex = 0;

			metroComboBox3.DisplayMember = "Text";
			metroComboBox3.ValueMember = "Value";
			metroComboBox3.Items.Add(new { Text = "F1", Value = "90" });
			metroComboBox3.Items.Add(new { Text = "F2", Value = "91" });
			metroComboBox3.Items.Add(new { Text = "F3", Value = "92" });
			metroComboBox3.Items.Add(new { Text = "F4", Value = "93" });
			metroComboBox3.Items.Add(new { Text = "F5", Value = "94" });
			metroComboBox3.Items.Add(new { Text = "F6", Value = "95" });
			metroComboBox3.Items.Add(new { Text = "F7", Value = "96" });
			metroComboBox3.Items.Add(new { Text = "F8", Value = "97" });
			metroComboBox3.Items.Add(new { Text = "F9", Value = "98" });
			metroComboBox3.Items.Add(new { Text = "F10", Value = "99" });
			metroComboBox3.Items.Add(new { Text = "F11", Value = "100" });
			metroComboBox3.Items.Add(new { Text = "F12", Value = "101" });
			metroComboBox3.Items.Add(new { Text = "Left Shift", Value = "116" });
			metroComboBox3.Items.Add(new { Text = "Right Shift", Value = "117" });
			metroComboBox3.Items.Add(new { Text = "Left Ctrl", Value = "118" });
			metroComboBox3.Items.Add(new { Text = "Right Ctrl", Value = "119" });
			metroComboBox3.Items.Add(new { Text = "Left Alt", Value = "120" });
			metroComboBox3.Items.Add(new { Text = "Right Alt", Value = "121" });
			metroComboBox3.SelectedIndex = 0;

			metroComboBox4.DisplayMember = "Text";
			metroComboBox4.ValueMember = "Value";
			metroComboBox4.Items.Add(new { Text = "F1", Value = "90" });
			metroComboBox4.Items.Add(new { Text = "F2", Value = "91" });
			metroComboBox4.Items.Add(new { Text = "F3", Value = "92" });
			metroComboBox4.Items.Add(new { Text = "F4", Value = "93" });
			metroComboBox4.Items.Add(new { Text = "F5", Value = "94" });
			metroComboBox4.Items.Add(new { Text = "F6", Value = "95" });
			metroComboBox4.Items.Add(new { Text = "F7", Value = "96" });
			metroComboBox4.Items.Add(new { Text = "F8", Value = "97" });
			metroComboBox4.Items.Add(new { Text = "F9", Value = "98" });
			metroComboBox4.Items.Add(new { Text = "F10", Value = "99" });
			metroComboBox4.Items.Add(new { Text = "F11", Value = "100" });
			metroComboBox4.Items.Add(new { Text = "F12", Value = "101" });
			metroComboBox4.Items.Add(new { Text = "Left Shift", Value = "116" });
			metroComboBox4.Items.Add(new { Text = "Right Shift", Value = "117" });
			metroComboBox4.Items.Add(new { Text = "Left Ctrl", Value = "118" });
			metroComboBox4.Items.Add(new { Text = "Right Ctrl", Value = "119" });
			metroComboBox4.Items.Add(new { Text = "Left Alt", Value = "120" });
			metroComboBox4.Items.Add(new { Text = "Right Alt", Value = "121" });
			metroComboBox4.SelectedIndex = 0;

			metroComboBox5.DisplayMember = "Text";
			metroComboBox5.ValueMember = "Value";
			metroComboBox5.Items.Add(new { Text = "F1", Value = "90" });
			metroComboBox5.Items.Add(new { Text = "F2", Value = "91" });
			metroComboBox5.Items.Add(new { Text = "F3", Value = "92" });
			metroComboBox5.Items.Add(new { Text = "F4", Value = "93" });
			metroComboBox5.Items.Add(new { Text = "F5", Value = "94" });
			metroComboBox5.Items.Add(new { Text = "F6", Value = "95" });
			metroComboBox5.Items.Add(new { Text = "F7", Value = "96" });
			metroComboBox5.Items.Add(new { Text = "F8", Value = "97" });
			metroComboBox5.Items.Add(new { Text = "F9", Value = "98" });
			metroComboBox5.Items.Add(new { Text = "F10", Value = "99" });
			metroComboBox5.Items.Add(new { Text = "F11", Value = "100" });
			metroComboBox5.Items.Add(new { Text = "F12", Value = "101" });
			metroComboBox5.Items.Add(new { Text = "Left Shift", Value = "116" });
			metroComboBox5.Items.Add(new { Text = "Right Shift", Value = "117" });
			metroComboBox5.Items.Add(new { Text = "Left Ctrl", Value = "118" });
			metroComboBox5.Items.Add(new { Text = "Right Ctrl", Value = "119" });
			metroComboBox5.Items.Add(new { Text = "Left Alt", Value = "120" });
			metroComboBox5.Items.Add(new { Text = "Right Alt", Value = "121" });
			metroComboBox5.SelectedIndex = 0;

			metroComboBox6.DisplayMember = "Text";
			metroComboBox6.ValueMember = "Value";
			metroComboBox6.Items.Add(new { Text = "F1", Value = "90" });
			metroComboBox6.Items.Add(new { Text = "F2", Value = "91" });
			metroComboBox6.Items.Add(new { Text = "F3", Value = "92" });
			metroComboBox6.Items.Add(new { Text = "F4", Value = "93" });
			metroComboBox6.Items.Add(new { Text = "F5", Value = "94" });
			metroComboBox6.Items.Add(new { Text = "F6", Value = "95" });
			metroComboBox6.Items.Add(new { Text = "F7", Value = "96" });
			metroComboBox6.Items.Add(new { Text = "F8", Value = "97" });
			metroComboBox6.Items.Add(new { Text = "F9", Value = "98" });
			metroComboBox6.Items.Add(new { Text = "F10", Value = "99" });
			metroComboBox6.Items.Add(new { Text = "F11", Value = "100" });
			metroComboBox6.Items.Add(new { Text = "F12", Value = "101" });
			metroComboBox6.Items.Add(new { Text = "Left Shift", Value = "116" });
			metroComboBox6.Items.Add(new { Text = "Right Shift", Value = "117" });
			metroComboBox6.Items.Add(new { Text = "Left Ctrl", Value = "118" });
			metroComboBox6.Items.Add(new { Text = "Right Ctrl", Value = "119" });
			metroComboBox6.Items.Add(new { Text = "Left Alt", Value = "120" });
			metroComboBox6.Items.Add(new { Text = "Right Alt", Value = "121" });
			metroComboBox6.SelectedIndex = 0;
		}

		private void Form1_Load(object sender, EventArgs e)
		{
		}

		private void KeyListener()
		{
			while (isRunning)
			{
				try
				{
					string hotkey = null;
					metroComboBox1.Invoke(new MethodInvoker(delegate ()
					{
						hotkey = (metroComboBox1.SelectedItem as dynamic).Value;
					}));

					Thread.Sleep(40);
					KeysConverter kc = new KeysConverter();
					Key key = (Key)kc.ConvertFromString(hotkey);
					if ((Keyboard.GetKeyStates(key) & KeyStates.Down) > 0)
					{
						if (autoEnter1.Checked)
						{
							if (fast != true)
							{
								Process[] processes = Process.GetProcessesByName("System");

								foreach (Process proc in processes)
								{
									SetForegroundWindow(proc.MainWindowHandle);
									SendKeys.SendWait("{ENTER}" + metroTextBox1.Text + "{ENTER}");
									Thread.Sleep(100);
								}
							}
							else
							{
								shell.SendKeys("{ENTER}" + metroTextBox1.Text + "{ENTER}");
								Thread.Sleep(100);
							}
						}
						else
						{
							if (fast != true)
							{
								Process[] processes = Process.GetProcessesByName("System");

								foreach (Process proc in processes)
								{
									SetForegroundWindow(proc.MainWindowHandle);
									SendKeys.SendWait(metroTextBox1.Text);
									Thread.Sleep(100);
								}
							}
							else
							{
								shell.SendKeys(metroTextBox1.Text);
								Thread.Sleep(100);
							}
						}
					}
				}
				catch { }
			}
		}

		private void KeyListener1()
		{
			while (isRunning2)
			{
				try
				{
					string hotkey = null;
					metroComboBox2.Invoke(new MethodInvoker(delegate ()
					{
						hotkey = (metroComboBox2.SelectedItem as dynamic).Value;
					}));

					Thread.Sleep(40);
					KeysConverter kc = new KeysConverter();
					Key key = (Key)kc.ConvertFromString(hotkey);
					if ((Keyboard.GetKeyStates(key) & KeyStates.Down) > 0)
					{
						if (autoEnter2.Checked)
						{
							if (fast2 != true)
							{
								Process[] processes = Process.GetProcessesByName("System");

								foreach (Process proc in processes)
								{
									SetForegroundWindow(proc.MainWindowHandle);
									SendKeys.SendWait("{ENTER}" + metroTextBox2.Text + "{ENTER}");
									Thread.Sleep(100);
								}
							}
							else
							{
								shell.SendKeys("{ENTER}" + metroTextBox2.Text + "{ENTER}");
								Thread.Sleep(100);
							}
						}
						else
						{
							if (fast2 != true)
							{
								Process[] processes = Process.GetProcessesByName("System");

								foreach (Process proc in processes)
								{
									SetForegroundWindow(proc.MainWindowHandle);
									SendKeys.SendWait(metroTextBox2.Text);
									Thread.Sleep(100);
								}
							}
							else
							{
								shell.SendKeys(metroTextBox2.Text);
								Thread.Sleep(100);
							}
						}
					}
				}
				catch { }
			}
		}

		private void KeyListener2()
		{
			while (isRunning3)
			{
				try
				{
					string hotkey = null;
					metroComboBox3.Invoke(new MethodInvoker(delegate ()
					{
						hotkey = (metroComboBox3.SelectedItem as dynamic).Value;
					}));

					Thread.Sleep(40);
					KeysConverter kc = new KeysConverter();
					Key key = (Key)kc.ConvertFromString(hotkey);
					if ((Keyboard.GetKeyStates(key) & KeyStates.Down) > 0)
					{
						if (autoEnter3.Checked)
						{
							if (fast3 != true)
							{
								Process[] processes = Process.GetProcessesByName("System");

								foreach (Process proc in processes)
								{
									SetForegroundWindow(proc.MainWindowHandle);
									SendKeys.SendWait("{ENTER}" + metroTextBox3.Text + "{ENTER}");
									Thread.Sleep(100);
								}
							}
							else
							{
								shell.SendKeys("{ENTER}" + metroTextBox3.Text + "{ENTER}");
								Thread.Sleep(100);
							}
						}
						else
						{
							if (fast3 != true)
							{
								Process[] processes = Process.GetProcessesByName("System");

								foreach (Process proc in processes)
								{
									SetForegroundWindow(proc.MainWindowHandle);
									SendKeys.SendWait(metroTextBox3.Text);
									Thread.Sleep(100);
								}
							}
							else
							{
								shell.SendKeys(metroTextBox3.Text);
								Thread.Sleep(100);
							}
						}
					}
				}
				catch { }
			}
		}

		private void KeyListener3()
		{
			while (isRunning4)
			{
				try
				{
					string hotkey = null;
					metroComboBox4.Invoke(new MethodInvoker(delegate ()
					{
						hotkey = (metroComboBox4.SelectedItem as dynamic).Value;
					}));

					Thread.Sleep(40);
					KeysConverter kc = new KeysConverter();
					Key key = (Key)kc.ConvertFromString(hotkey);
					if ((Keyboard.GetKeyStates(key) & KeyStates.Down) > 0)
					{
						if (autoEnter4.Checked)
						{
							if (fast4 != true)
							{
								Process[] processes = Process.GetProcessesByName("System");

								foreach (Process proc in processes)
								{
									SetForegroundWindow(proc.MainWindowHandle);
									SendKeys.SendWait("{ENTER}" + metroTextBox4.Text + "{ENTER}");
									Thread.Sleep(100);
								}
							}
							else
							{
								shell.SendKeys("{ENTER}" + metroTextBox4.Text + "{ENTER}");
								Thread.Sleep(100);
							}
						}
						else
						{
							if (fast4 != true)
							{
								Process[] processes = Process.GetProcessesByName("System");

								foreach (Process proc in processes)
								{
									SetForegroundWindow(proc.MainWindowHandle);
									SendKeys.SendWait(metroTextBox4.Text);
									Thread.Sleep(100);
								}
							}
							else
							{
								shell.SendKeys(metroTextBox4.Text);
								Thread.Sleep(100);
							}
						}
					}
				}
				catch { }
			}
		}

		private void KeyListener4()
		{
			while (isRunning5)
			{
				try
				{
					string hotkey = null;
					metroComboBox5.Invoke(new MethodInvoker(delegate ()
					{
						hotkey = (metroComboBox5.SelectedItem as dynamic).Value;
					}));

					Thread.Sleep(40);
					KeysConverter kc = new KeysConverter();
					Key key = (Key)kc.ConvertFromString(hotkey);
					if ((Keyboard.GetKeyStates(key) & KeyStates.Down) > 0)
					{
						if (autoEnter5.Checked)
						{
							if (fast5 != true)
							{
								Process[] processes = Process.GetProcessesByName("System");

								foreach (Process proc in processes)
								{
									SetForegroundWindow(proc.MainWindowHandle);
									SendKeys.SendWait("{ENTER}" + metroTextBox5.Text + "{ENTER}");
									Thread.Sleep(100);
								}
							}
							else
							{
								shell.SendKeys("{ENTER}" + metroTextBox5.Text + "{ENTER}");
								Thread.Sleep(100);
							}
						}
						else
						{
							if (fast5 != true)
							{
								Process[] processes = Process.GetProcessesByName("System");

								foreach (Process proc in processes)
								{
									SetForegroundWindow(proc.MainWindowHandle);
									SendKeys.SendWait(metroTextBox5.Text);
									Thread.Sleep(100);
								}
							}
							else
							{
								shell.SendKeys(metroTextBox5.Text);
								Thread.Sleep(100);
							}
						}
					}
				}
				catch { }
			}
		}

		private void KeyListener5()
		{
			while (isRunning6)
			{
				try
				{
					string hotkey = null;
					metroComboBox6.Invoke(new MethodInvoker(delegate ()
					{
						hotkey = (metroComboBox6.SelectedItem as dynamic).Value;
					}));

					Thread.Sleep(40);
					KeysConverter kc = new KeysConverter();
					Key key = (Key)kc.ConvertFromString(hotkey);
					if ((Keyboard.GetKeyStates(key) & KeyStates.Down) > 0)
					{
						if (autoEnter6.Checked)
						{
							if (fast6 != true)
							{
								Process[] processes = Process.GetProcessesByName("System");

								foreach (Process proc in processes)
								{
									SetForegroundWindow(proc.MainWindowHandle);
									SendKeys.SendWait("{ENTER}" + metroTextBox6.Text + "{ENTER}");
									Thread.Sleep(100);
								}
							}
							else
							{
								shell.SendKeys("{ENTER}" + metroTextBox6.Text + "{ENTER}");
								Thread.Sleep(100);
							}
						}
						else
						{
							if (fast6 != true)
							{
								Process[] processes = Process.GetProcessesByName("System");

								foreach (Process proc in processes)
								{
									SetForegroundWindow(proc.MainWindowHandle);
									SendKeys.SendWait(metroTextBox6.Text);
									Thread.Sleep(100);
								}
							}
							else
							{
								shell.SendKeys(metroTextBox6.Text);
								Thread.Sleep(100);
							}
						}
					}
				}
				catch { }
			}
		}

		private void metroCheckBox1_CheckedChanged(object sender, EventArgs e)
		{
			Thread TH = new Thread(KeyListener);
			if (metroCheckBox1.Checked)
			{
				isRunning = true;
				TH.ApartmentState = ApartmentState.STA;
				TH.Start();
			}
			else
			{
				isRunning = false;
				TH.Abort();
			}
		}

		private void metroCheckBox2_CheckedChanged(object sender, EventArgs e)
		{
			Thread TH = new Thread(KeyListener1);
			if (metroCheckBox2.Checked)
			{
				isRunning2 = true;
				TH.ApartmentState = ApartmentState.STA;
				TH.Start();
			}
			else
			{
				isRunning2 = false;
				TH.Abort();
			}
		}

		private void metroCheckBox3_CheckedChanged(object sender, EventArgs e)
		{
			Thread TH = new Thread(KeyListener2);
			if (metroCheckBox3.Checked)
			{
				isRunning3 = true;
				TH.ApartmentState = ApartmentState.STA;
				TH.Start();
			}
			else
			{
				isRunning3 = false;
				TH.Abort();
			}
		}

		private void metroCheckBox4_CheckedChanged(object sender, EventArgs e)
		{
			Thread TH = new Thread(KeyListener3);
			if (metroCheckBox4.Checked)
			{
				isRunning4 = true;
				TH.ApartmentState = ApartmentState.STA;
				TH.Start();
			}
			else
			{
				isRunning4 = false;
				TH.Abort();
			}
		}

		private void metroCheckBox5_CheckedChanged(object sender, EventArgs e)
		{
			Thread TH = new Thread(KeyListener4);
			if (metroCheckBox5.Checked)
			{
				isRunning5 = true;
				TH.ApartmentState = ApartmentState.STA;
				TH.Start();
			}
			else
			{
				isRunning5 = false;
				TH.Abort();
			}
		}

		private void metroCheckBox6_CheckedChanged(object sender, EventArgs e)
		{
			Thread TH = new Thread(KeyListener5);
			if (metroCheckBox6.Checked)
			{
				isRunning6 = true;
				TH.ApartmentState = ApartmentState.STA;
				TH.Start();
			}
			else
			{
				isRunning6 = false;
				TH.Abort();
			}
		}

		private void Form1_FormClosed(object sender, FormClosedEventArgs e)
		{
			Environment.Exit(1);
		}

		private void Form1_Load_1(object sender, EventArgs e)
		{

		}

		private void metroCheckBox7_CheckedChanged(object sender, EventArgs e)
		{
			if (metroCheckBox7.Checked)
				fast = true;
			else
				fast = false;
		}

		private void metroCheckBox9_CheckedChanged(object sender, EventArgs e)
		{
			if (metroCheckBox9.Checked)
				fast2 = true;
			else
				fast2 = false;
		}

		private void metroCheckBox12_CheckedChanged(object sender, EventArgs e)
		{
			if (metroCheckBox12.Checked)
				fast3 = true;
			else
				fast3 = false;
		}

		private void metroCheckBox11_CheckedChanged(object sender, EventArgs e)
		{
			if (metroCheckBox11.Checked)
				fast4 = true;
			else
				fast4 = false;
		}

		private void metroCheckBox10_CheckedChanged(object sender, EventArgs e)
		{
			if (metroCheckBox10.Checked)
				fast5 = true;
			else
				fast5 = false;
		}

		private void metroCheckBox8_CheckedChanged(object sender, EventArgs e)
		{
			if (metroCheckBox8.Checked)
				fast6 = true;
			else
				fast6 = false;
		}
	}
}
