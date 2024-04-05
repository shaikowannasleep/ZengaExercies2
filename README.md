# ZengaExercies
ZengaExercies 3D training code
 - **Version**: Unity 2022 (LTS)
Lưu ý: Các bài tập làm chung vào 1 project Unity, mỗi bài là 1 folder chứa scene và code của bài đó. Sau đó gửi lại project chỉ bao gồm các folder Assets, Packages, ProjectSettings, UserSettings trong 1 file zip, xem mẫu dưới đây:
XXX-ZengaExercies 
--Assets
----Exercise1
------Scenes
------Scripts
----Exercise2
------Scenes
------Scripts
--Packages
--ProjectSettings
--UserSettings
XXX = tên người làm bài tập
#  Bài tập 0 ( Assets/Exercise1 )
Cho một camera, một cube, và một quad. Bấm giữ trái chuột và rê chuột trên bề mặt quad, box sẽ di chuyển trên bề mặt quad theo vị trí chuột 
Yêu cầu:
- Sử dụng Raycast
- Không sử dụng OnMouseDrag
# Bài tập Rotate 1 ( Assets/Exercise2 )
Cho một camera và một quad. Bấm giữ trái chuột và rê chuột trên bề mặt quad, quad sẽ xoay quanh tâm của nó theo vị trí chuột 
Yêu cầu:
- Sử dụng Raycast
- Không sử dụng OnMouseDrag
# Bài tập Rotate 2 ( Assets/Exercise3 )
Cho một camera. Bấm giữ trái chuột và rê chuột ở bất cứ đâu, camera sẽ quay theo (chỉ quay trái phải), và có giới hạn trái, giới hạn phải. Lưu ý: đoạn xoay của camera phải tương ứng với đoạn rê của chuột, trên mọi kích thước màn hình. 
