# Kuyruklu Bulmaca (Scorpion Puzzle) - Proje Mantığı ve Yapısı

Bu belge, oyunun temel mimarisini, kod yapısını ve geliştirme sürecindeki mantığı detaylandırmaktadır.

## 1. Genel Mimari
Oyun, Unity motoru üzerinde C# dili kullanılarak geliştirilmiştir. Modüler bir yapı hedeflenmiş olup, her sistem kendi yöneticisi (Manager) üzerinden kontrol edilmektedir.

## 2. Temel Sistemler

| Sistem | Açıklama | Dosya |
| :--- | :--- | :--- |
| **Oyun Motoru** | 4'lü eşleşme, patlama ve kombo mekaniklerini yönetir. | `GameManager.cs` |
| **Seviye Sistemi** | Bölüm kilitleri, yıldız ödülleri ve zorluk algoritmasını içerir. | `LevelManager.cs` |
| **Görev Sistemi** | Günlük, haftalık ve sezonluk görevleri dinamik olarak oluşturur. | `QuestManager.cs` |
| **AI İpucu** | Oyunculara neon gösterimli ipuçları sağlar ve hak yönetimini yapar. | `AIHintSystem.cs` |
| **Ekonomi** | Akrep Jetonu ve Premium Kristal işlemlerini yönetir. | `EconomyManager.cs` |
| **Oyuncu Profili** | Giriş sistemleri (Google/Apple) ve başarımları takip eder. | `PlayerManager.cs` |
| **UI Yönetimi** | Menüler arası geçişleri ve arayüz etkileşimlerini kontrol eder. | `UIManager.cs` |

## 3. Geliştirme Mantığı
- **Eşleşme Mekaniği:** Blokların 4'lü gruplar halinde eşleşmesi üzerine kurulu bir algoritma kullanılmıştır.
- **Ekonomi Dengesi:** Oyun içi kazanılan jetonlar ile satın alınan kristaller arasında bir denge gözetilmiştir.
- **Görsel Kimlik:** "Neon Akrep Evreni" temasına uygun olarak UI ve efekt yapıları kurgulanmıştır.

## 4. GitHub Entegrasyonu
Proje kodları [ozkannebi53/Kuyruklu-bulmaca](https://github.com/ozkannebi53/Kuyruklu-bulmaca) reposuna push edilmiştir.

---
**Geliştirici:** Manus AI
**Tarih:** 13 Haziran 2026
