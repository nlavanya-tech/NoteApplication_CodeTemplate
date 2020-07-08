using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NoteApplication.BusinessLogics.Interface;
using NoteApplication.Entities;
using NoteApplication.Models;

namespace NoteApplication.Controllers
{
    public class NotesAppController : Controller
    {
        private readonly INoteService _service;
        //private InMemoryConnection DbContext;
        public NotesAppController(INoteService service)
        {
            _service = service;
        }
        public IActionResult AddNewNotes()
        {
            return View();
        }
        //Send notes to server for create notes and redirect to Home page
        [HttpPost]
        public async Task<ActionResult> SubmitNote(Notes notes)
        {
            await _service.CreateAsync(notes);
            return RedirectToAction("Index", "Home");
        }
        //Get all Notes from server
        [HttpGet]
        public async Task<ActionResult> GetAllNotes()
        {
            throw new NotImplementedException();
        }
        //Get All status from server
        [HttpGet]
        public async Task<ActionResult> GetAllNoteStatus()
        {
            throw new NotImplementedException();
        }
        //send notes to server for Update 
        [HttpPut]
        public async Task<ActionResult> UpdateNotes(Notes notes)
        {
            throw new NotImplementedException();
        }
        //send notes id to server for delete and redirect to NotesApp
        [HttpDelete]
        public async Task<ActionResult> DeleteNotes(Notes notes)
        {
            throw new NotImplementedException();
        }

    }
}