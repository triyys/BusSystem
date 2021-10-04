using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusSystemUI
{
    public interface IEditWindow
    {
        /// <summary>
        /// Hiển thị các thông tin Bus mà người dùng chọn để chỉnh sửa
        /// </summary>
        void WireUpFields();
    }
}
