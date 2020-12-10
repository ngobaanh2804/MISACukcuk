using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QLNV.Models
{
    #region Declare
    #endregion

    #region Constructor
    #endregion

    #region Property
    /// <summary>
    /// Nhân viên
    /// </summary>
    /// CreatedBy: Ngô Bá Anh (1/12/2020)
    public class Employee
    {
        /// <summary>
        /// Khóa chính
        /// </summary>
        public Guid EmployeeId { get; set; }
        /// <summary>
        /// Mã nhân viên
        /// </summary>
        public string EmployeeCode { get; set; }
        /// <summary>
        /// Tên nhân viên
        /// </summary>
        public string EmployeeName { get; set; }
        /// <summary>
        /// Giới tính (0-Nữ, 1-Nam, 2-Khác)
        /// </summary>
        public int? Gender { get; set; }
        /// <summary>
        /// Ngày sinh
        /// </summary>
        public DateTime? Birthday { get; set; }
        /// <summary>
        /// Số điện thoai
        /// </summary>
        public string PhoneNumber { get; set; }
        /// <summary>
        /// Email
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// Quốc tịch
        /// </summary>
        public string National { get; set; }
        /// <summary>
        /// Chứng minh thư/Hộ chiếu
        /// </summary>
        public string Identification { get; set; }
        /// <summary>
        /// Ngày cấp
        /// </summary>
        public DateTime? IssueDate { get; set; }
        /// <summary>
        /// Nơi cấp
        /// </summary>
        public string IssueBy { get; set; }
        /// <summary>
        /// Lương
        /// </summary>
        public decimal? Salary { get; set; }
        /// <summary>
        /// Phòng ban
        /// </summary>
        public Guid? DepartmentId { get; set; }
        /// <summary>
        /// Vị trí/CHức vụ
        /// </summary>
        public Guid? PossitionId { get; set; }
    }
    #endregion

    #region Method
    #endregion
}
