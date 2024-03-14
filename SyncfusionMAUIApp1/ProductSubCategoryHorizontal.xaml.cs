using System.Collections.ObjectModel;
using System.Net.Http.Headers;

namespace SyncfusionMAUIApp1;

public partial class ProductSubCategoryHorizontal : ContentPage
{
	public ProductSubCategoryHorizontal()
	{
		InitializeComponent();
	}
}

public class CategoryMapRepository
{
	public CategoryMapRepository() 
	{
		
	}

	internal ObservableCollection<ListCategorySubCatInfo> GetCategoryMap()
	{
		var listItems = new ObservableCollection<ListCategorySubCatInfo>()
		{
			new ListCategorySubCatInfo()
			{
				  Category = new ItemInfo()
				  {
					   CatImage = "https://ik.imagekit.io/u4aiacsbos/electronics.png?updatedAt=1710323769302",
						Description ="All the samsung phones are available",
						 Name = "Samsung All Phones"
				  },
				  SubCategories = new List<ItemInfo>()
				  {
					 new ItemInfo()
					 {
						 Name= "Model 1",
						 Description="All the features are available",
						 CatImage ="https://ik.imagekit.io/u4aiacsbos/Sam1.png?updatedAt=1710341588210"
                     },
					  new ItemInfo()
					  {
						   CatImage = "https://ik.imagekit.io/u4aiacsbos/SamsungAll.jpg?updatedAt=1710341659617",
							Description ="All the features are available",
							 Name ="Model 2"
					  },
					  new ItemInfo()
					  {
                            CatImage = "https://ik.imagekit.io/u4aiacsbos/Sam4.jpeg?updatedAt=1710341588101",
                            Description ="All the features are available",
                             Name ="Model 3"
                      }
				  }
			},
			new ListCategorySubCatInfo()
			{
                 Category = new ItemInfo()
                  {
                       CatImage = "https://ik.imagekit.io/u4aiacsbos/electronics.png?updatedAt=1710323769302",
                        Description ="All the new Iphones are available",
                         Name = "Iphone All Phones"
                  },
                  SubCategories = new List<ItemInfo>()
                  {
                     new ItemInfo()
                     {
                         Name= "Apple 1",
                         Description="All the features are available",
                         CatImage ="https://ik.imagekit.io/u4aiacsbos/Iphone2.png?updatedAt=1710341588079"
                     },
                      new ItemInfo()
                      {
                           CatImage = "https://ik.imagekit.io/u4aiacsbos/Iphone1.png?updatedAt=1710341588006",
                            Description ="All the features are available",
                             Name ="Apple 2"
                      }
                    
                  }
            },
			
		};

		return listItems;
	}
}

public class ItemInfo
{
	public string Name { get; set; }
	public string Description { get; set; }
	public string CatImage { get; set; }
}

public class ListCategorySubCatInfo
{
	public ItemInfo Category { get; set; }
	public List<ItemInfo> SubCategories { get; set; }
}

public class LayoutViewModel
{
	public LayoutViewModel ()
	{
		GenerateSource();
	}
	public ObservableCollection<ListCategorySubCatInfo> ListCategoryMapDetails { get; set; }
	private void GenerateSource()
	{
		CategoryMapRepository repo =  new CategoryMapRepository();
		ListCategoryMapDetails = repo.GetCategoryMap();
	}
}