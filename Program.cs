using System;
using System.Drawing;
using System.Windows.Forms;

using Circular;

ApplicationConfiguration.Initialize();

var form = new Form
{
    Text = "Meu Aplicativo",
    WindowState = FormWindowState.Maximized,
    FormBorderStyle = FormBorderStyle.None
};

// form.BackColor = Color.Blue;
// form.ShowInTaskbar = false;

var a = 0;

Label label = new()
{
    Location = new Point(10, 10),
    Text = "Points: " + a,
    Width = 300,
    Height = 100,
    Font = new Font("Calibri", 20) 
};


CircularButton button = new()
{
    Text = "Click here!",
    Width = 50,
    Height = 50,
    BackColor = Color.Red,
    Location = new Point(400, 400)
};

button.Click += (o, e) =>
{
    a++;
    button.Location = new Point
    (
        Random.Shared.Next(form.Width),
        Random.Shared.Next(form.Height)
    );
    label.Text = "Points: " + a;
};

form.Controls.Add(button);
form.Controls.Add(label);

Application.Run(form);
