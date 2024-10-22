# SurvivorWebApiCRUD ENG || TR 

## You will create a Web API application for the Survivor competition. This application will include a relationship between competitors and categories and will provide CRUD (Create, Read, Update, Delete) operations for these relationships through API endpoints.
#### While creating the necessary Entities for the tables, use a BaseEntity class.
- Create a CompetitorController and a CategoryController. These controllers should be able to perform the following CRUD operations:
##### CompetitorController:

- GET /api/competitors - List all competitors.
- GET /api/competitors/{id} - Get a specific competitor by ID.
- GET /api/competitors/categories/{CategoryId} - Get competitors by Category ID.
- POST /api/competitors - Create a new competitor.
- PUT /api/competitors/{id} - Update a specific competitor.
- DELETE /api/competitors/{id} - Delete a specific competitor.
  
##### CategoryController:

- GET /api/categories - List all categories.
- GET /api/categories/{id} - Get a specific category by ID.
- POST /api/categories - Create a new category.
- PUT /api/categories/{id} - Update a specific category.
- DELETE /api/categories/{id} - Delete a specific category.

- #### API test
###### Using the Postman and Swagger API test
- Category Swagger and Postman API test
###### ![image](https://github.com/user-attachments/assets/1f42952f-5984-4eb4-ad68-400923ad9108)
###### ![image](https://github.com/user-attachments/assets/e4277246-0952-4f01-9e0f-77bf91f5fdd3)
###### ![image](https://github.com/user-attachments/assets/bbdd4407-4851-4f58-b1b9-0e0d178c543b)


---
- Competitor Swagger and Postman API test 
###### ![image](https://github.com/user-attachments/assets/79adf3ff-ed88-49c8-b672-18abdd14992d)
###### ![image](https://github.com/user-attachments/assets/29ff4eee-ac25-41b2-8d9b-977addd03472)
###### ![image](https://github.com/user-attachments/assets/a873425b-57ac-4573-821a-7a57dd52de1b)



---
## Survivor yarışması için bir Web API uygulaması oluşturacaksınız. Bu uygulama, yarışmacılar ve kategoriler arasında bir ilişki içerecek ve bu ilişkilerle ilgili CRUD (Create, Read, Update, Delete) işlemlerini gerçekleştiren API endpointler içerecektir.

#### Tablolar için gerekli Entityleri oluştururken bir BaseEntity Class'ından yardım alınız.

- Bir CompetitorController ve bir CategoryController oluşturun. Bu controller'lar aşağıdaki CRUD işlemlerini yapabilmelidir:

##### CompetitorController:
- GET /api/competitors - Tüm yarışmacıları listele.
- GET /api/competitors/{id} - Belirli bir yarışmacıyı getir.
- GET /api/competitors/categories/{CategoryId} - Kategori Id'ye göre yarışmacıları getir.
- POST /api/competitors - Yeni bir yarışmacı oluştur.
- PUT /api/competitors/{id} - Belirli bir yarışmacıyı güncelle.
- DELETE /api/competitors/{id} - Belirli bir yarışmacıyı sil.

##### CategoryController:
- GET /api/categories - Tüm kategorileri listele.
- GET /api/categories/{id} - Belirli bir kategoriyi getir.
- POST /api/categories - Yeni bir kategori oluştur.
- PUT /api/categories/{id} - Belirli bir kategoriyi güncelle.
- DELETE /api/categories/{id} - Belirli bir kategoriyi sil.


