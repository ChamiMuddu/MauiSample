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
		var listCategoryInfo =  new ObservableCollection<ListCategoryInfo>()
		{
			 new ListCategoryInfo()
			 {
				  CategoryName = "Fashion",
				  CategoryDescription = "This is to view Fashionable items",
				  CategoryImage = "https://ik.imagekit.io/u4aiacsbos/cam-1709548483657.jpg?updatedAt=1709548490146"
             },
			 new ListCategoryInfo()
			 {
                  CategoryName = "Books",
                  CategoryDescription = "This is to view Book items",
                  CategoryImage = "https://ik.imagekit.io/u4aiacsbos/cam-1709548461640.jpg?updatedAt=1709548490077"
             },
			 new ListCategoryInfo()
			 {
                  CategoryName = "Electronics",
                  CategoryDescription = "This is to view Electronic items",
                  CategoryImage = "https://ik.imagekit.io/u4aiacsbos/cam-1709548471905.jpg?updatedAt=1709548490072"
             },
              new ListCategoryInfo()
             {
                  CategoryName = "Watches",
                  CategoryDescription = "This is to view Watch items",
                  CategoryImage = "https://ik.imagekit.io/u4aiacsbos/cam-1709548452105.jpg?updatedAt=1709548489851"
             },
             new ListCategoryInfo()
             {
                  CategoryName = "Toys",
                  CategoryDescription = "This is to view kid items",
                  CategoryImage = "https://ik.imagekit.io/u4aiacsbos/cam-1709548435521.jpg?updatedAt=1709548442006"
             },
             new ListCategoryInfo()
             {
                  CategoryName = "Furniture",
                  CategoryDescription = "This is to view furnitue items",
                  CategoryImage = "https://ik.imagekit.io/u4aiacsbos/cam-1709548411170.jpg?updatedAt=1709548418363"
             },
              new ListCategoryInfo()
             {
                  CategoryName = "Books",
                  CategoryDescription = "This is to view Book items",
                  CategoryImage = "https://ik.imagekit.io/u4aiacsbos/cam-1709548461640.jpg?updatedAt=1709548490077"
             },
             new ListCategoryInfo()
             {
                  CategoryName = "Electronics",
                  CategoryDescription = "This is to view Electronic items",
                  CategoryImage = "https://ik.imagekit.io/u4aiacsbos/cam-1709548471905.jpg?updatedAt=1709548490072"
             },
              new ListCategoryInfo()
             {
                  CategoryName = "Watches",
                  CategoryDescription = "This is to view Watch items",
                  CategoryImage = "https://ik.imagekit.io/u4aiacsbos/cam-1709548452105.jpg?updatedAt=1709548489851"
             },
             new ListCategoryInfo()
             {
                  CategoryName = "Toys",
                  CategoryDescription = "This is to view kid items",
                  CategoryImage = "https://ik.imagekit.io/u4aiacsbos/cam-1709548435521.jpg?updatedAt=1709548442006"
             },
             new ListCategoryInfo()
             {
                  CategoryName = "Furniture",
                  CategoryDescription = "This is to view furnitue items",
                  CategoryImage = "https://ik.imagekit.io/u4aiacsbos/cam-1709548411170.jpg?updatedAt=1709548418363"
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

    private void GenerateSource()
    {
        CategoryRepository repository = new CategoryRepository();
        ListCategoryDetails =  repository.GetListCategory();
    }
}