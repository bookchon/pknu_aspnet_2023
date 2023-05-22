using aspnet_boardapp.Data;
using aspnet_boardapp.Models;
using Microsoft.AspNetCore.Mvc;

namespace _02_boardapp.Controllers
{
    // https://localhost:7800/Board/Index
    // GetMethod로 화면을 URL로 부를 때 액션

    public class BoardController : Controller
    {
        private readonly ApplicationDbContext _db;

        public BoardController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index() // 게시판 초기화면 리스트
        {
            IEnumerable<Board> objBoardList = _db.Boards.ToList();  // Select query
            return View(objBoardList);
        }

        // https://localhost:7217
        
        public IActionResult Create() // 게시판 글쓰기
        {
            return View();
        }

        // Submit이 발생하여 내부로 데이터를 전달 하는 액션 

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Board board)
        {
            _db.Boards.Add(board); // INSERT
            _db.SaveChanges(); // COMMIT

            return RedirectToAction("Index", "Board");
        }
    }
}