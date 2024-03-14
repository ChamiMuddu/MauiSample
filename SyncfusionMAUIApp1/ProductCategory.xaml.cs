using System.Collections.ObjectModel;

namespace SyncfusionMAUIApp1;

public partial class ProductCategory : ContentPage
{
	public ProductCategory()
	{
		InitializeComponent();
	}

    private void listView_ItemDragging(object sender, Syncfusion.Maui.ListView.ItemDraggingEventArgs e)
    {
        if(e.Action == Syncfusion.Maui.ListView.DragAction.Drop)
        {
            // This is just for demo -- optional code
            this.DisplayIndex.Text = String.Format("Item dragged from position {0} to {1}", e.OldIndex, e.NewIndex);
        }
    }
}

public class	ListCategoryInfo
{
    public string CategoryName { get; set; }
    public string CategoryDescription { get; set; }
    public string CategoryImage { get; set; } 
}

public class CategoryRepository
{
	public CategoryRepository()
	{ }
	internal ObservableCollection<ListCategoryInfo> GetListCategory()
	{
        var listCategoryInfo = new ObservableCollection<ListCategoryInfo>()
        {
             new ListCategoryInfo()
             {
                  CategoryName = "Mobiles",
                  CategoryDescription = "This is to view Electronic items Clothing describes the material and the technical garment",
                  CategoryImage = "https://ik.imagekit.io/u4aiacsbos/electronics.png?updatedAt=1710323769302"
             },
             new ListCategoryInfo()
             {
                  CategoryName = "Fashion",
                  CategoryDescription = "This is to view Fashion items Clothing describes the material and the technical garment",
				  CategoryImage = "https://ik.imagekit.io/u4aiacsbos/fashion.png?updatedAt=1710323646967"
             },
			 new ListCategoryInfo()
			 {
                  CategoryName = "Books",
                  CategoryDescription = "This is to view Book items Clothing describes the material and the technical garment",
                  CategoryImage = "https://ik.imagekit.io/u4aiacsbos/books.png?updatedAt=1710323719470"
             },
			
              new ListCategoryInfo()
             {
                  CategoryName = "Watches",
                  CategoryDescription = "This is to view Watch items Clothing describes the material and the technical garment",
                  CategoryImage = "https://ik.imagekit.io/u4aiacsbos/watches.png?updatedAt=1710323803897"
             },
             new ListCategoryInfo()
             {
                  CategoryName = "Toys",
                  CategoryDescription = "This is to view kid items Clothing describes the material and the technical garment",
                  CategoryImage = "https://ik.imagekit.io/u4aiacsbos/toys.png?updatedAt=1710323868971"
             },
             new ListCategoryInfo()
             {
                  CategoryName = "Furniture",
                  CategoryDescription = "This is to view furnitue items Clothing describes the material and the technical garment",
                  CategoryImage = "https://ik.imagekit.io/u4aiacsbos/furniture.png?updatedAt=1710323868969"
             },
              new ListCategoryInfo()
             {
                  CategoryName = "Books",
                  CategoryDescription = "This is to view Book items Clothing describes the material and the technical garment",
                  CategoryImage = "https://ik.imagekit.io/u4aiacsbos/books.png?updatedAt=1710323719470"
             },
             new ListCategoryInfo()
             {
                  CategoryName = "Electronics",
                  CategoryDescription = "This is to view Electronic items Clothing describes the material and the technical garment",
                  CategoryImage = "https://ik.imagekit.io/u4aiacsbos/electronics.png?updatedAt=1710323769302"
             },
              new ListCategoryInfo()
             {
                  CategoryName = "Watches",
                  CategoryDescription = "This is to view Watch items Clothing describes the material and the technical garment",
                  CategoryImage = "https://ik.imagekit.io/u4aiacsbos/watches.png?updatedAt=1710323803897"
             },
             new ListCategoryInfo()
             {
                  CategoryName = "Toys",
                  CategoryDescription = "This is to view kid items Clothing describes the material and the technical garment",
                  CategoryImage = "https://ik.imagekit.io/u4aiacsbos/toys.png?updatedAt=1710323868971"
             },
             new ListCategoryInfo()
             {
                  CategoryName = "Furniture",
                  CategoryDescription = "This is to view furnitue items Clothing describes the material and the technical garment",
                  CategoryImage = "https://ik.imagekit.io/u4aiacsbos/furniture.png?updatedAt=1710323868969"
             }
        };
		

		return listCategoryInfo;
	}
}

public class LinearLayoutViewModel
{
    public LinearLayoutViewModel()
    {
        GenerateSource();
    }

    public ObservableCollection<ListCategoryInfo> ListCategoryDetails { get; set; }
    public Command ArchiveCommand { get; set; }
    public Command DeleteCommand { get; set; }
    public Command TapCommand { get; set; }
    

    private void GenerateSource()
    {
        CategoryRepository repository = new CategoryRepository();
        ListCategoryDetails =  repository.GetListCategory();
        ArchiveCommand = new Command(Archive);
        DeleteCommand = new Command(Delete);
        TapCommand = new Command(Tapped);
    }

    private ListCategoryInfo? listViewItem;
    private void   Archive(object item)
    {
        listViewItem = (ListCategoryInfo)item;
        var currentCollection = this.ListCategoryDetails;
        currentCollection.Remove(listViewItem);
    }

    private void Delete(object item)
    {
        listViewItem = (ListCategoryInfo)item;
        var currentCollection = this.ListCategoryDetails;
        currentCollection.Remove(listViewItem);
    }

    private async void Tapped(object obj)
    {
        var navigationParameter = new Dictionary<string, object>() { { "category", obj } };
        await Shell.Current.GoToAsync("//ProductSubCategoryHorizontal", navigationParameter);
    }
}