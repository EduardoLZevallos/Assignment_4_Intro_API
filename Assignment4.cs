public class Assignment4
{
	public Assignment4()
	{
	}

	interface TestInferface
    {

		public string Suject
		{
			get { return subject; }
			set => subject = value;
		}

		public float OverallGpa
		{
			get { return overall_gpa; }
            set { overall_gpa = value; }

		}

        string subject { get; set; }
        float overall_gpa { get; set; }

		public delegate void Assignment4Handler(object source, EventArgs args);
		public event Assignment4Handler Grader;

		protected virtual void OnAssignment()
		{
			if (Grader != null)
				Grader(this, null);
		}
     }	
}

class Program
{
	static void Main(string[] args)
	{
		var test = new Assignment4();
	}
}




