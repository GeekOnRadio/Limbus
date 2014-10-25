
// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow
{
	private global::Gtk.HBox hbxMain;
	
	private global::Gtk.VBox vbxButtons;
	
	private global::Gtk.HBox hbxSetpoint;
	
	private global::Gtk.Label lblSetpoint;
	
	private global::Gtk.Entry edSetpoint;
	
	private global::Gtk.HBox hbox7;
	
	private global::Gtk.Label lblTime;
	
	private global::Gtk.Entry edTime;
	
	private global::Gtk.Button btnSend;

	protected virtual void Build ()
	{
		global::Stetic.Gui.Initialize (this);
		// Widget MainWindow
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString ("Limbus Laboratory");
		this.Icon = global::Stetic.IconLoader.LoadIcon (this, "gtk-execute", global::Gtk.IconSize.Menu);
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.hbxMain = new global::Gtk.HBox ();
		this.hbxMain.Name = "hbxMain";
		this.hbxMain.Spacing = 6;
		// Container child hbxMain.Gtk.Box+BoxChild
		this.vbxButtons = new global::Gtk.VBox ();
		this.vbxButtons.Name = "vbxButtons";
		this.vbxButtons.Spacing = 6;
		// Container child vbxButtons.Gtk.Box+BoxChild
		this.hbxSetpoint = new global::Gtk.HBox ();
		this.hbxSetpoint.Name = "hbxSetpoint";
		this.hbxSetpoint.Spacing = 6;
		// Container child hbxSetpoint.Gtk.Box+BoxChild
		this.lblSetpoint = new global::Gtk.Label ();
		this.lblSetpoint.Name = "lblSetpoint";
		this.lblSetpoint.LabelProp = global::Mono.Unix.Catalog.GetString ("Setpoint:");
		this.hbxSetpoint.Add (this.lblSetpoint);
		global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.hbxSetpoint [this.lblSetpoint]));
		w1.Position = 0;
		w1.Expand = false;
		w1.Fill = false;
		// Container child hbxSetpoint.Gtk.Box+BoxChild
		this.edSetpoint = new global::Gtk.Entry ();
		this.edSetpoint.CanFocus = true;
		this.edSetpoint.Name = "edSetpoint";
		this.edSetpoint.IsEditable = true;
		this.edSetpoint.InvisibleChar = '●';
		this.hbxSetpoint.Add (this.edSetpoint);
		global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hbxSetpoint [this.edSetpoint]));
		w2.Position = 1;
		this.vbxButtons.Add (this.hbxSetpoint);
		global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.vbxButtons [this.hbxSetpoint]));
		w3.Position = 0;
		w3.Expand = false;
		w3.Fill = false;
		// Container child vbxButtons.Gtk.Box+BoxChild
		this.hbox7 = new global::Gtk.HBox ();
		this.hbox7.Name = "hbox7";
		this.hbox7.Spacing = 6;
		// Container child hbox7.Gtk.Box+BoxChild
		this.lblTime = new global::Gtk.Label ();
		this.lblTime.Name = "lblTime";
		this.lblTime.LabelProp = global::Mono.Unix.Catalog.GetString ("Time:");
		this.hbox7.Add (this.lblTime);
		global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.hbox7 [this.lblTime]));
		w4.Position = 0;
		w4.Expand = false;
		w4.Fill = false;
		// Container child hbox7.Gtk.Box+BoxChild
		this.edTime = new global::Gtk.Entry ();
		this.edTime.CanFocus = true;
		this.edTime.Name = "edTime";
		this.edTime.IsEditable = true;
		this.edTime.InvisibleChar = '●';
		this.hbox7.Add (this.edTime);
		global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.hbox7 [this.edTime]));
		w5.Position = 1;
		this.vbxButtons.Add (this.hbox7);
		global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.vbxButtons [this.hbox7]));
		w6.Position = 1;
		w6.Expand = false;
		w6.Fill = false;
		// Container child vbxButtons.Gtk.Box+BoxChild
		this.btnSend = new global::Gtk.Button ();
		this.btnSend.CanFocus = true;
		this.btnSend.Name = "btnSend";
		this.btnSend.UseUnderline = true;
		this.btnSend.Label = global::Mono.Unix.Catalog.GetString ("Send");
		this.vbxButtons.Add (this.btnSend);
		global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.vbxButtons [this.btnSend]));
		w7.Position = 2;
		w7.Expand = false;
		w7.Fill = false;
		this.hbxMain.Add (this.vbxButtons);
		global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.hbxMain [this.vbxButtons]));
		w8.Position = 1;
		w8.Expand = false;
		w8.Fill = false;
		this.Add (this.hbxMain);
		if ((this.Child != null)) {
			this.Child.ShowAll ();
		}
		this.DefaultWidth = 400;
		this.DefaultHeight = 300;
		this.Show ();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler (this.OnDeleteEvent);
		this.btnSend.Clicked += new global::System.EventHandler (this.btnSendClicked);
	}
}
