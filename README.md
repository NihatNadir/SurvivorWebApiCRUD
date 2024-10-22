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
###### ![image](https://github.com/user-attachments/assets/36c82d23-c3cd-47f7-a2fa-0b70e298c656)
###### ![image](https://github.com/user-attachments/assets/2f82f4df-d1f8-4b1b-a13d-dd0dc96d1eef)
###### ![image](https://github.com/user-attachments/assets/aa7df85b-eaf4-44fd-bbf3-133840b061fc)
###### ![image](https://github.com/user-attachments/assets/abca3d6c-612a-4a5a-bdf6-2831a778ce45)
###### ![image](https://github.com/user-attachments/assets/5642149a-1275-43b5-820e-8d134f133ab4)
###### ![image](https://github.com/user-attachments/assets/8064624b-1b0c-4ff9-865f-c7ab6511555d)
---
- Competitor Swagger and Postman API test 
###### ![image](https://github.com/user-attachments/assets/c97472b8-e802-4f3b-b158-fc37d05ed88c)
###### ![image](https://github.com/user-attachments/assets/08de97a2-7d86-4e90-84a5-dc0f2d0763bb)
###### ![image](https://github.com/user-attachments/assets/c13faa4b-e4ae-48af-9530-134e5d282f98)
###### ![image](https://github.com/user-attachments/assets/110872f2-cb78-4e74-a735-dc9314493c20)
###### ![image](https://github.com/user-attachments/assets/550d83a4-8732-49c4-9a5a-5c69db2d4193)

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


