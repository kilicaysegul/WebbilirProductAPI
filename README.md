# 🚀 WebbilirProductAPI

Shopify platformu ile entegre çalışan, ürün yönetimi ve veri senkronizasyonu süreçlerini optimize etmek için geliştirilmiş bir **.NET Core Web API** projesidir.

---

## 📌 Proje Hakkında

**WebbilirProductAPI**, Shopify mağazalarındaki ürün verilerini çekmek, güncellemek ve yönetmek amacıyla geliştirilmiştir. Modern yazılım mimarisi prensiplerine uygun olarak tasarlanmış olup, **ölçeklenebilir**, **performanslı** ve **güvenli** bir yapı sunar.

---

## ✨ Temel Özellikler

- 🔗 **Shopify Entegrasyonu**  
  Shopify Admin API üzerinden ürün verilerinin senkronizasyonu

- 📦 **Ürün Yönetimi**  
  Ürün listeleme, detay görüntüleme ve güncelleme işlemleri

- ⚡ **Yüksek Performans**  
  .NET’in asenkron programlama yapısı ile optimize edilmiş API istekleri

- 🔐 **Güvenli Kimlik Doğrulama**  
  Standart yetkilendirme mekanizmaları ile API güvenliği

---

## 🛠 Kullanılan Teknolojiler

- **Framework:** .NET 8 / .NET Core  
- **Dil:** C#  
- **Entegrasyon:** Shopify Admin API  
- **Araçlar:** Swagger, Postman  

---

## 💻 Kurulum ve Çalıştırma

Projeyi lokal ortamda çalıştırmak için aşağıdaki adımları izleyin:

### 1️⃣ Depoyu Klonlayın
```bash
git clone https://github.com/kilicaysegul/WebbilirProductAPI.git
cd WebbilirProductAPI
```

### 2️⃣ Bağımlılıkları Yükleyin
```bash
dotnet restore
```

### 3️⃣ appsettings.json Yapılandırması

Shopify API bilgilerinizi ekleyin:

```json
"ShopifyConfig": {
  "ApiKey": "YOUR_API_KEY",
  "Password": "YOUR_API_PASSWORD",
  "StoreUrl": "your-store.myshopify.com"
}
```

### 4️⃣ Projeyi Çalıştırın
```bash
dotnet run
```

---

## 📄 API Dokümantasyonu

Uygulama çalıştıktan sonra Swagger arayüzüne aşağıdaki adresten erişebilirsiniz:

```
https://localhost:XXXX/swagger/index.html
```

---

## 📌 Notlar

- ⚠️ Proje aktif olarak geliştirilmektedir.  
- 🤝 Katkıda bulunmak için Pull Request gönderebilirsiniz.  

---

## 👩‍💻 Geliştirici
Ayşegül Kılıç
