namespace Task1_square_
{
    public partial class Form1 : Form
    {
        
       private int labelCount = 0;
       private Point Upp { get; set; }
       private Point Downn { get; set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            Downn = e.Location;

        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
           
            Button button =  new Button();

            button.Click += (s,e)=>
          

            button.AutoSize = true;
            button.Text = labelCount++.ToString();
            button.Size = new Size(e.Location.Y - Downn.Y , e.Location.Y - Downn.Y);
            if (e.Location.X > Downn.X && e.Location.Y > Downn.Y)
                button.Location = Downn;

            

            

            else if (e.Location.X < Downn.X && e.Location.Y < Downn.Y)
            {
                button.Location = new Point(Downn.X, e.Location.Y);
                button.Size = new Size(Downn.Y - e.Location.Y, e.Location.Y - e.Location.Y);

            }
            else if (e.Location.X < Downn.X && e.Location.Y > Downn.Y)
button.Location = new Point(Downn.X - (e.Location.Y - Downn.Y), Downn.Y);
            else if (e.Location.X > Downn.X && e.Location.Y < Downn.Y)
            {
                button.Location = new Point(Downn.X, e.Location.Y);
                button.Size = new Size(Downn.Y - e.Location.Y, e.Location.Y - e.Location.Y);

            }


            button.BackColor = Color.Cyan;
            Controls.Add(button);





        }
    }
}