using System;

public class NhietKe
{
	private double _Temprature;

	public double Temprature
	{
		get { return _Temprature; }
		set { 
			_Temprature = value;
			TempratureChange(value);
		}
	}

	private event EventHandler<TempratureChangedArr> _TempChanged;
	public event EventHandler<TempratureChangedArr> TempChanged
	{
		add { _TempChanged += value; }
		remove { _TempChanged -= value; }
	}

	void TempratureChange(double value)
	{
		if (_TempChanged != null)
		{
			_TempChanged(this, new TempratureChangedArr(value));
		}
	}
}

public class TempratureChangedArr : EventArgs
{
	public double TempratureEV { get; set; }
	public TempratureChangedArr(double value)
	{
		this.TempratureEV = value;
	}
}

