﻿using Schoolmanagement.BusinessLayer.Interfaces;
using Schoolmanagement.BusinessLayer.Services.Repository;
using Schoolmanagement.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Schoolmanagement.BusinessLayer.Services
{
    public class SchoolServices : ISchoolServices
    {
        /// <summary>
        /// Creating referance variable of ISchoolRepository and injecting in SchoolServices controller
        /// </summary>
        private readonly ISchoolRepository _sRepository;
        public SchoolServices(ISchoolRepository schoolRepository)
        {
            _sRepository = schoolRepository;
        }
        /// <summary>
        /// Get all book from database
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<Library>> AllBook()
        {
            //Do code here
            throw new NotImplementedException();
        }
        /// <summary>
        /// Get all notice from databse and show on main page
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<Notice>> AllNotice()
        {
            //Do code here
            throw new NotImplementedException();
        }
        /// <summary>
        /// get all student from database
        /// </summary>
        /// <returns></returns>
        public Task<IEnumerable<Student>> AllStudent()
        {
            //Do code here
            throw new NotImplementedException();
        }
        /// <summary>
        /// Get all teacher from databse
        /// </summary>
        /// <returns></returns>
        public Task<IEnumerable<Teacher>> AllTeacher()
        {
            //Do code here
            throw new NotImplementedException();
        }
        /// <summary>
        /// Get all book list from databse
        /// </summary>
        /// <returns></returns>
        public Task<IEnumerable<Library>> BookList()
        {
            //Do code here
            throw new NotImplementedException();
        }
        /// <summary>
        /// Borrow a book
        /// </summary>
        /// <param name="BookId"></param>
        /// <param name="bookBorrow"></param>
        /// <returns></returns>
        public Task<BookBorrow> BorrowBook(int BookId, BookBorrow bookBorrow)
        {
            //Do code here
            throw new NotImplementedException();
        }
        /// <summary>
        /// Get borrow book info and use while returining book
        /// </summary>
        /// <param name="BorrowId"></param>
        /// <returns></returns>
        public async Task<BookBorrow> BorrowInfo(int BorrowId)
        {
            //Do code here
            throw new NotImplementedException();
        }
        /// <summary>
        /// Find a book from Db by its name
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public async Task<IEnumerable<Notice>> FindNotice(string name)
        {
            //Do code here
            throw new NotImplementedException();
        }
        /// <summary>
        /// Find an existing student from db
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public async Task<IEnumerable<Student>> FindStudent(string name)
        {
            //Do code here
            throw new NotImplementedException();
        }
    }
}
