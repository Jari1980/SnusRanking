# SnusRanking

<p>This is a small C# MVC refreshment project.</p>
<p>Project is connected to MSSQL server and if table Snus is empty a set of Snus is seeded at start.</p>
<p>Each Snus object have a image, stored as byte[] in db and converted as .png in View, the images are placeholders saved in static section, as .png, under images which are seeded to DB.</p>
<p>In front page result of three queries is presented, these are passed as ViewBag, TempData and SessionObject from controller to View. ViewBag and TempData are only accessible within the httpendpoint "index", as in homepage, while SessionObject could be invoked anywhere in this project, during the time of 60mins which is configured in program.cs, not using this more but just for the fun of it.</p>
<p>In Rank page user can drag and drop Snus images to desired rank.</p>
<br/>
<img width="1240" height="1148" alt="RankTheSnus" src="https://github.com/user-attachments/assets/360aa210-d9c2-42a1-8e0e-f0a8fe83c2b3" />
