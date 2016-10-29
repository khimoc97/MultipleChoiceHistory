// 
//  ____  _     __  __      _        _ 
// |  _ \| |__ |  \/  | ___| |_ __ _| |
// | | | | '_ \| |\/| |/ _ \ __/ _` | |
// | |_| | |_) | |  | |  __/ || (_| | |
// |____/|_.__/|_|  |_|\___|\__\__,_|_|
//
// Auto-generated from main on 2016-10-30 02:23:51Z.
// Please visit http://code.google.com/p/dblinq2007/ for more information.
//
using System;
using System.ComponentModel;
using System.Data;
#if MONO_STRICT
	using System.Data.Linq;
#else   // MONO_STRICT
using DbLinq.Data.Linq;
using DbLinq.Vendor;
#endif  // MONO_STRICT
using System.Data.Linq.Mapping;
using System.Diagnostics;

public partial class Main : DataContext
{
	
	#region Extensibility Method Declarations
		partial void OnCreated();
		#endregion
	
	
	public Main(string connectionString) : 
			base(connectionString)
	{
		this.OnCreated();
	}
	
	public Main(string connection, MappingSource mappingSource) : 
			base(connection, mappingSource)
	{
		this.OnCreated();
	}
	
	public Main(IDbConnection connection, MappingSource mappingSource) : 
			base(connection, mappingSource)
	{
		this.OnCreated();
	}
	
	public Table<Chapters> Chapters
	{
		get
		{
			return this.GetTable<Chapters>();
		}
	}
	
	public Table<Lessons> Lessons
	{
		get
		{
			return this.GetTable<Lessons>();
		}
	}
	
	public Table<Questions> Questions
	{
		get
		{
			return this.GetTable<Questions>();
		}
	}
	
	public Table<Subjects> Subjects
	{
		get
		{
			return this.GetTable<Subjects>();
		}
	}
}

#region Start MONO_STRICT
#if MONO_STRICT

public partial class Main
{
	
	public Main(IDbConnection connection) : 
			base(connection)
	{
		this.OnCreated();
	}
}
#region End MONO_STRICT
	#endregion
#else     // MONO_STRICT

public partial class Main
{
	
	public Main(IDbConnection connection) : 
			base(connection, new DbLinq.Sqlite.SqliteVendor())
	{
		this.OnCreated();
	}
	
	public Main(IDbConnection connection, IVendor sqlDialect) : 
			base(connection, sqlDialect)
	{
		this.OnCreated();
	}
	
	public Main(IDbConnection connection, MappingSource mappingSource, IVendor sqlDialect) : 
			base(connection, mappingSource, sqlDialect)
	{
		this.OnCreated();
	}
}
#region End Not MONO_STRICT
	#endregion
#endif     // MONO_STRICT
#endregion

[Table(Name="main.Chapters")]
public partial class Chapters : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
{
	
	private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
	
	private System.Nullable<int> _id;
	
	private string _name;
	
	private System.Nullable<int> _subjectID;
	
	private EntitySet<Lessons> _lessons;
	
	private EntityRef<Subjects> _subjects = new EntityRef<Subjects>();
	
	#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnIDChanged();
		
		partial void OnIDChanging(System.Nullable<int> value);
		
		partial void OnNameChanged();
		
		partial void OnNameChanging(string value);
		
		partial void OnSubjectIDChanged();
		
		partial void OnSubjectIDChanging(System.Nullable<int> value);
		#endregion
	
	
	public Chapters()
	{
		_lessons = new EntitySet<Lessons>(new Action<Lessons>(this.Lessons_Attach), new Action<Lessons>(this.Lessons_Detach));
		this.OnCreated();
	}
	
	[Column(Storage="_id", Name="ID", DbType="integer identity", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never)]
	[DebuggerNonUserCode()]
	public System.Nullable<int> ID
	{
		get
		{
			return this._id;
		}
		set
		{
			if ((_id != value))
			{
				this.OnIDChanging(value);
				this.SendPropertyChanging();
				this._id = value;
				this.SendPropertyChanged("ID");
				this.OnIDChanged();
			}
		}
	}
	
	[Column(Storage="_name", Name="Name", DbType="nvarchar(50)", AutoSync=AutoSync.Never)]
	[DebuggerNonUserCode()]
	public string Name
	{
		get
		{
			return this._name;
		}
		set
		{
			if (((_name == value) 
						== false))
			{
				this.OnNameChanging(value);
				this.SendPropertyChanging();
				this._name = value;
				this.SendPropertyChanged("Name");
				this.OnNameChanged();
			}
		}
	}
	
	[Column(Storage="_subjectID", Name="SubjectID", DbType="integer", AutoSync=AutoSync.Never)]
	[DebuggerNonUserCode()]
	public System.Nullable<int> SubjectID
	{
		get
		{
			return this._subjectID;
		}
		set
		{
			if ((_subjectID != value))
			{
				if (_subjects.HasLoadedOrAssignedValue)
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.OnSubjectIDChanging(value);
				this.SendPropertyChanging();
				this._subjectID = value;
				this.SendPropertyChanged("SubjectID");
				this.OnSubjectIDChanged();
			}
		}
	}
	
	#region Children
	[Association(Storage="_lessons", OtherKey="ChaptersID", ThisKey="ID", Name="fk_Lessons_0")]
	[DebuggerNonUserCode()]
	public EntitySet<Lessons> Lessons
	{
		get
		{
			return this._lessons;
		}
		set
		{
			this._lessons = value;
		}
	}
	#endregion
	
	#region Parents
	[Association(Storage="_subjects", OtherKey="ID", ThisKey="SubjectID", Name="fk_Chapters_0", IsForeignKey=true)]
	[DebuggerNonUserCode()]
	public Subjects Subjects
	{
		get
		{
			return this._subjects.Entity;
		}
		set
		{
			if (((this._subjects.Entity == value) 
						== false))
			{
				if ((this._subjects.Entity != null))
				{
					Subjects previousSubjects = this._subjects.Entity;
					this._subjects.Entity = null;
					previousSubjects.Chapters.Remove(this);
				}
				this._subjects.Entity = value;
				if ((value != null))
				{
					value.Chapters.Add(this);
					_subjectID = value.ID;
				}
				else
				{
					_subjectID = null;
				}
			}
		}
	}
	#endregion
	
	public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
	
	public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
	
	protected virtual void SendPropertyChanging()
	{
		System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
		if ((h != null))
		{
			h(this, emptyChangingEventArgs);
		}
	}
	
	protected virtual void SendPropertyChanged(string propertyName)
	{
		System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
		if ((h != null))
		{
			h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
		}
	}
	
	#region Attachment handlers
	private void Lessons_Attach(Lessons entity)
	{
		this.SendPropertyChanging();
		entity.Chapters = this;
	}
	
	private void Lessons_Detach(Lessons entity)
	{
		this.SendPropertyChanging();
		entity.Chapters = null;
	}
	#endregion
}

[Table(Name="main.Lessons")]
public partial class Lessons : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
{
	
	private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
	
	private System.Nullable<int> _chaptersID;
	
	private string _description;
	
	private System.Nullable<int> _id;
	
	private string _name;
	
	private EntitySet<Questions> _questions;
	
	private EntityRef<Chapters> _chapters = new EntityRef<Chapters>();
	
	#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnChaptersIDChanged();
		
		partial void OnChaptersIDChanging(System.Nullable<int> value);
		
		partial void OnDescriptionChanged();
		
		partial void OnDescriptionChanging(string value);
		
		partial void OnIDChanged();
		
		partial void OnIDChanging(System.Nullable<int> value);
		
		partial void OnNameChanged();
		
		partial void OnNameChanging(string value);
		#endregion
	
	
	public Lessons()
	{
		_questions = new EntitySet<Questions>(new Action<Questions>(this.Questions_Attach), new Action<Questions>(this.Questions_Detach));
		this.OnCreated();
	}
	
	[Column(Storage="_chaptersID", Name="ChaptersID", DbType="integer", AutoSync=AutoSync.Never)]
	[DebuggerNonUserCode()]
	public System.Nullable<int> ChaptersID
	{
		get
		{
			return this._chaptersID;
		}
		set
		{
			if ((_chaptersID != value))
			{
				if (_chapters.HasLoadedOrAssignedValue)
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.OnChaptersIDChanging(value);
				this.SendPropertyChanging();
				this._chaptersID = value;
				this.SendPropertyChanged("ChaptersID");
				this.OnChaptersIDChanged();
			}
		}
	}
	
	[Column(Storage="_description", Name="Description", DbType="nvarchar(1000)", AutoSync=AutoSync.Never)]
	[DebuggerNonUserCode()]
	public string Description
	{
		get
		{
			return this._description;
		}
		set
		{
			if (((_description == value) 
						== false))
			{
				this.OnDescriptionChanging(value);
				this.SendPropertyChanging();
				this._description = value;
				this.SendPropertyChanged("Description");
				this.OnDescriptionChanged();
			}
		}
	}
	
	[Column(Storage="_id", Name="ID", DbType="integer identity", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never)]
	[DebuggerNonUserCode()]
	public System.Nullable<int> ID
	{
		get
		{
			return this._id;
		}
		set
		{
			if ((_id != value))
			{
				this.OnIDChanging(value);
				this.SendPropertyChanging();
				this._id = value;
				this.SendPropertyChanged("ID");
				this.OnIDChanged();
			}
		}
	}
	
	[Column(Storage="_name", Name="Name", DbType="nvarchar(50)", AutoSync=AutoSync.Never)]
	[DebuggerNonUserCode()]
	public string Name
	{
		get
		{
			return this._name;
		}
		set
		{
			if (((_name == value) 
						== false))
			{
				this.OnNameChanging(value);
				this.SendPropertyChanging();
				this._name = value;
				this.SendPropertyChanged("Name");
				this.OnNameChanged();
			}
		}
	}
	
	#region Children
	[Association(Storage="_questions", OtherKey="LessonID", ThisKey="ID", Name="fk_Questions_0")]
	[DebuggerNonUserCode()]
	public EntitySet<Questions> Questions
	{
		get
		{
			return this._questions;
		}
		set
		{
			this._questions = value;
		}
	}
	#endregion
	
	#region Parents
	[Association(Storage="_chapters", OtherKey="ID", ThisKey="ChaptersID", Name="fk_Lessons_0", IsForeignKey=true)]
	[DebuggerNonUserCode()]
	public Chapters Chapters
	{
		get
		{
			return this._chapters.Entity;
		}
		set
		{
			if (((this._chapters.Entity == value) 
						== false))
			{
				if ((this._chapters.Entity != null))
				{
					Chapters previousChapters = this._chapters.Entity;
					this._chapters.Entity = null;
					previousChapters.Lessons.Remove(this);
				}
				this._chapters.Entity = value;
				if ((value != null))
				{
					value.Lessons.Add(this);
					_chaptersID = value.ID;
				}
				else
				{
					_chaptersID = null;
				}
			}
		}
	}
	#endregion
	
	public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
	
	public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
	
	protected virtual void SendPropertyChanging()
	{
		System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
		if ((h != null))
		{
			h(this, emptyChangingEventArgs);
		}
	}
	
	protected virtual void SendPropertyChanged(string propertyName)
	{
		System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
		if ((h != null))
		{
			h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
		}
	}
	
	#region Attachment handlers
	private void Questions_Attach(Questions entity)
	{
		this.SendPropertyChanging();
		entity.Lessons = this;
	}
	
	private void Questions_Detach(Questions entity)
	{
		this.SendPropertyChanging();
		entity.Lessons = null;
	}
	#endregion
}

[Table(Name="main.Questions")]
public partial class Questions : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
{
	
	private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
	
	private string _ans1;
	
	private string _ans2;
	
	private string _ans3;
	
	private string _ans4;
	
	private System.Nullable<int> _correctAns;
	
	private System.Nullable<int> _id;
	
	private System.Nullable<int> _lessonID;
	
	private string _question;
	
	private System.Nullable<int> _type;
	
	private EntityRef<Lessons> _lessons = new EntityRef<Lessons>();
	
	#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnAns1Changed();
		
		partial void OnAns1Changing(string value);
		
		partial void OnAns2Changed();
		
		partial void OnAns2Changing(string value);
		
		partial void OnAns3Changed();
		
		partial void OnAns3Changing(string value);
		
		partial void OnAns4Changed();
		
		partial void OnAns4Changing(string value);
		
		partial void OnCorrectAnsChanged();
		
		partial void OnCorrectAnsChanging(System.Nullable<int> value);
		
		partial void OnIDChanged();
		
		partial void OnIDChanging(System.Nullable<int> value);
		
		partial void OnLessonIDChanged();
		
		partial void OnLessonIDChanging(System.Nullable<int> value);
		
		partial void OnQuestionChanged();
		
		partial void OnQuestionChanging(string value);
		
		partial void OnTypeChanged();
		
		partial void OnTypeChanging(System.Nullable<int> value);
		#endregion
	
	
	public Questions()
	{
		this.OnCreated();
	}
	
	[Column(Storage="_ans1", Name="Ans1", DbType="nvarchar(50)", AutoSync=AutoSync.Never)]
	[DebuggerNonUserCode()]
	public string Ans1
	{
		get
		{
			return this._ans1;
		}
		set
		{
			if (((_ans1 == value) 
						== false))
			{
				this.OnAns1Changing(value);
				this.SendPropertyChanging();
				this._ans1 = value;
				this.SendPropertyChanged("Ans1");
				this.OnAns1Changed();
			}
		}
	}
	
	[Column(Storage="_ans2", Name="Ans2", DbType="nvarchar(50)", AutoSync=AutoSync.Never)]
	[DebuggerNonUserCode()]
	public string Ans2
	{
		get
		{
			return this._ans2;
		}
		set
		{
			if (((_ans2 == value) 
						== false))
			{
				this.OnAns2Changing(value);
				this.SendPropertyChanging();
				this._ans2 = value;
				this.SendPropertyChanged("Ans2");
				this.OnAns2Changed();
			}
		}
	}
	
	[Column(Storage="_ans3", Name="Ans3", DbType="nvarchar(50)", AutoSync=AutoSync.Never)]
	[DebuggerNonUserCode()]
	public string Ans3
	{
		get
		{
			return this._ans3;
		}
		set
		{
			if (((_ans3 == value) 
						== false))
			{
				this.OnAns3Changing(value);
				this.SendPropertyChanging();
				this._ans3 = value;
				this.SendPropertyChanged("Ans3");
				this.OnAns3Changed();
			}
		}
	}
	
	[Column(Storage="_ans4", Name="Ans4", DbType="nvarchar(50)", AutoSync=AutoSync.Never)]
	[DebuggerNonUserCode()]
	public string Ans4
	{
		get
		{
			return this._ans4;
		}
		set
		{
			if (((_ans4 == value) 
						== false))
			{
				this.OnAns4Changing(value);
				this.SendPropertyChanging();
				this._ans4 = value;
				this.SendPropertyChanged("Ans4");
				this.OnAns4Changed();
			}
		}
	}
	
	[Column(Storage="_correctAns", Name="CorrectAns", DbType="int", AutoSync=AutoSync.Never)]
	[DebuggerNonUserCode()]
	public System.Nullable<int> CorrectAns
	{
		get
		{
			return this._correctAns;
		}
		set
		{
			if ((_correctAns != value))
			{
				this.OnCorrectAnsChanging(value);
				this.SendPropertyChanging();
				this._correctAns = value;
				this.SendPropertyChanged("CorrectAns");
				this.OnCorrectAnsChanged();
			}
		}
	}
	
	[Column(Storage="_id", Name="ID", DbType="integer identity", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never)]
	[DebuggerNonUserCode()]
	public System.Nullable<int> ID
	{
		get
		{
			return this._id;
		}
		set
		{
			if ((_id != value))
			{
				this.OnIDChanging(value);
				this.SendPropertyChanging();
				this._id = value;
				this.SendPropertyChanged("ID");
				this.OnIDChanged();
			}
		}
	}
	
	[Column(Storage="_lessonID", Name="LessonID", DbType="integer", AutoSync=AutoSync.Never)]
	[DebuggerNonUserCode()]
	public System.Nullable<int> LessonID
	{
		get
		{
			return this._lessonID;
		}
		set
		{
			if ((_lessonID != value))
			{
				if (_lessons.HasLoadedOrAssignedValue)
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.OnLessonIDChanging(value);
				this.SendPropertyChanging();
				this._lessonID = value;
				this.SendPropertyChanged("LessonID");
				this.OnLessonIDChanged();
			}
		}
	}
	
	[Column(Storage="_question", Name="Question", DbType="nvarchar(200)", AutoSync=AutoSync.Never)]
	[DebuggerNonUserCode()]
	public string Question
	{
		get
		{
			return this._question;
		}
		set
		{
			if (((_question == value) 
						== false))
			{
				this.OnQuestionChanging(value);
				this.SendPropertyChanging();
				this._question = value;
				this.SendPropertyChanged("Question");
				this.OnQuestionChanged();
			}
		}
	}
	
	[Column(Storage="_type", Name="type", DbType="integer", AutoSync=AutoSync.Never)]
	[DebuggerNonUserCode()]
	public System.Nullable<int> Type
	{
		get
		{
			return this._type;
		}
		set
		{
			if ((_type != value))
			{
				this.OnTypeChanging(value);
				this.SendPropertyChanging();
				this._type = value;
				this.SendPropertyChanged("Type");
				this.OnTypeChanged();
			}
		}
	}
	
	#region Parents
	[Association(Storage="_lessons", OtherKey="ID", ThisKey="LessonID", Name="fk_Questions_0", IsForeignKey=true)]
	[DebuggerNonUserCode()]
	public Lessons Lessons
	{
		get
		{
			return this._lessons.Entity;
		}
		set
		{
			if (((this._lessons.Entity == value) 
						== false))
			{
				if ((this._lessons.Entity != null))
				{
					Lessons previousLessons = this._lessons.Entity;
					this._lessons.Entity = null;
					previousLessons.Questions.Remove(this);
				}
				this._lessons.Entity = value;
				if ((value != null))
				{
					value.Questions.Add(this);
					_lessonID = value.ID;
				}
				else
				{
					_lessonID = null;
				}
			}
		}
	}
	#endregion
	
	public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
	
	public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
	
	protected virtual void SendPropertyChanging()
	{
		System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
		if ((h != null))
		{
			h(this, emptyChangingEventArgs);
		}
	}
	
	protected virtual void SendPropertyChanged(string propertyName)
	{
		System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
		if ((h != null))
		{
			h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
		}
	}
}

[Table(Name="main.Subjects")]
public partial class Subjects : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
{
	
	private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
	
	private System.Nullable<int> _id;
	
	private string _name;
	
	private EntitySet<Chapters> _chapters;
	
	#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnIDChanged();
		
		partial void OnIDChanging(System.Nullable<int> value);
		
		partial void OnNameChanged();
		
		partial void OnNameChanging(string value);
		#endregion
	
	
	public Subjects()
	{
		_chapters = new EntitySet<Chapters>(new Action<Chapters>(this.Chapters_Attach), new Action<Chapters>(this.Chapters_Detach));
		this.OnCreated();
	}
	
	[Column(Storage="_id", Name="ID", DbType="integer identity", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never)]
	[DebuggerNonUserCode()]
	public System.Nullable<int> ID
	{
		get
		{
			return this._id;
		}
		set
		{
			if ((_id != value))
			{
				this.OnIDChanging(value);
				this.SendPropertyChanging();
				this._id = value;
				this.SendPropertyChanged("ID");
				this.OnIDChanged();
			}
		}
	}
	
	[Column(Storage="_name", Name="Name", DbType="nvarchar(50)", AutoSync=AutoSync.Never)]
	[DebuggerNonUserCode()]
	public string Name
	{
		get
		{
			return this._name;
		}
		set
		{
			if (((_name == value) 
						== false))
			{
				this.OnNameChanging(value);
				this.SendPropertyChanging();
				this._name = value;
				this.SendPropertyChanged("Name");
				this.OnNameChanged();
			}
		}
	}
	
	#region Children
	[Association(Storage="_chapters", OtherKey="SubjectID", ThisKey="ID", Name="fk_Chapters_0")]
	[DebuggerNonUserCode()]
	public EntitySet<Chapters> Chapters
	{
		get
		{
			return this._chapters;
		}
		set
		{
			this._chapters = value;
		}
	}
	#endregion
	
	public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
	
	public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
	
	protected virtual void SendPropertyChanging()
	{
		System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
		if ((h != null))
		{
			h(this, emptyChangingEventArgs);
		}
	}
	
	protected virtual void SendPropertyChanged(string propertyName)
	{
		System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
		if ((h != null))
		{
			h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
		}
	}
	
	#region Attachment handlers
	private void Chapters_Attach(Chapters entity)
	{
		this.SendPropertyChanging();
		entity.Subjects = this;
	}
	
	private void Chapters_Detach(Chapters entity)
	{
		this.SendPropertyChanging();
		entity.Subjects = null;
	}
	#endregion
}
