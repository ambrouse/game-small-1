# 🎮 Game Small 1

> "Một game phong cách pixel art ..."

---

## 📜 Mục lục
- [Giới thiệu](#giới-thiệu)
- [Ảnh minh họa](#ảnh-minh-họa)
- [Cấu trúc dự án](#cấu-trúc-dự-án)
- [Cách cài đặt](#cách-cài-đặt)
- [Cách chạy game](#cách-chạy-game)
- [Cấu hình hệ thống](#cấu-hình-hệ-thống)
- [Công nghệ sử dụng](#công-nghệ-sử-dụng)
- [Tác giả / Nhóm phát triển](#tác-giả--nhóm-phát-triển)
- [Ghi chú phát triển](#ghi-chú-phát-triển)
- [License](#license)

---

## 🧩 Giới thiệu
- **Thể loại:** Platformer / RPG / Action / Puzzle / v.v.  
- **Đồ họa:** 2D pixel / 3D low-poly / hand-drawn / v.v.  
- **Chức năng chính:**
  - Di chuyển, nhảy, tấn công, nhặt vật phẩm  
  - Hệ thống nhiệm vụ, boss, map  
  - Lưu tiến trình game  
  - Menu / cài đặt / âm thanh  

---

## 🖼️ Ảnh minh họa
*(Thêm 2–3 hình ảnh hoặc GIF mô tả gameplay)*

---

## 📂 Cấu trúc dự án

My project/
├── Assets
    ├── Animations/ # Animation clips & controllers
    ├── Sprites/ # Ảnh, texture, sprite pixel art
    ├── Audios/ # Nhạc nền, âm thanh hiệu ứng
    ├── Prefabs/ # Các prefab của enemy, item, player...
    ├── Scenes/ # Tất cả scene trong game
    ├── Scripts/ # Code C# (theo module)
    │ ├── UI
    │ └── Gameplay
    │     ├── Enemy/
    │     └── Managers/
    ├── UI/ # Canvas, button, HUD, ...
    └── Settings/ # Input, Graphics, Tag, Layer config

---

## ⚙️ Cách cài đặt

### 1️⃣ Clone repo
- ```bash
- git clone https://github.com/ambrouse/game-small-1.git

### 2️⃣ Mở bằng Unity
- Phiên bản: Unity Editor version 6000.0.26f1 LTS (Unity 6)
- Mở thư mục chứa project bằng Unity Hub → Add Project

### 3️⃣ Cài đặt package
- Cinemachine
- TextMeshPro
- Vào Window → Package Manager → Install.

---

## ⚙️ Cách cài đặt

| Thành phần    | Tối thiểu               | Khuyến nghị           |
| ------------- | ----------------------- | --------------------- |
| Unity Version | 2021.3 LTS              | Mới nhất có thể       |
| RAM           | 4GB                     | 8GB+                  |
| GPU           | Intel HD                | GTX 1050 hoặc cao hơn |
| Hệ điều hành  | Windows / macOS / Linux | Windows 10+           |

---

## 🧠 Công nghệ sử dụng

- Engine: Unity
- Ngôn ngữ: C#
- Hệ thống Input: Unity Input System
- Đồ họa: Sprite 2D, Pixel Perfect
- Âm thanh: AudioMixer
- Công cụ hỗ trợ: Photoshop / Aseprite / Blender / Audacity

---

## 👨‍💻 Tác giả / Nhóm phát triển

| Vai trò   | Tên | Liên hệ |
| --------- | --- | ------- |
| Lập trình | ... | ...     |
| Thiết kế  | ... | ...     |
| Âm thanh  | ... | ...     |

---

## 🧾 Ghi chú phát triển

- Các vấn đề đang phát triển:
  - Thêm AI cho enemy
  - Tối ưu vật lý khi nhảy
  - Thêm chế độ multiplayer

- Hướng mở rộng trong tương lai:
  - Online save / leaderboard
  - Hệ thống nhiệm vụ nâng cao

---

## ⚖️ License

- Chỉ sử dụng cho mục đích học tập, không thương mại.

---

## 🏁 Ghi chú thêm

/Models/ : chứa model AI
/Data/   : chứa file cấu hình

