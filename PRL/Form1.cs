using BUS.Services;

namespace PRL
{
    public partial class Form1 : Form
    {
        private NhanvienService service;
        //khai báo id đang được chọn;
        private string idWhenClick;
        public Form1()
        {
            InitializeComponent();
            service = new NhanvienService();
            LoadGrid();
        }

        private void LoadGrid()
        {
            dtgView.ColumnCount = 6;
            dtgView.Columns[0].Name = "Mã Nv";
            dtgView.Columns[1].Name = "Họ Tên";
            dtgView.Columns[2].Name = "Ngày Sinh";
            dtgView.Columns[3].Name = "Địa chỉ";
            dtgView.Columns[4].Name = "Phái";
            dtgView.Columns[5].Name = "Lương";
            //nếu có load lại trang thì không bị gấp đôi dữ liệu
            dtgView.Rows.Clear();
            //
            foreach(var nv in service.GetNhanviens())
            {
                dtgView.Rows.Add(nv.Manv,
                                 nv.Hoten,
                                 nv.Ngsinh,
                                 nv.Dchi,
                                 nv.Phai == false ? "Nam" : "Nữ",
                                 nv.Luong);
            }

        }

        private void dtgView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //lấy dòng hiện tại mình đang click vào
            int index = e.RowIndex;
            if (index < 0)
            {
                return;
            }
            //nếu bấm đúng dòng có dữ liệu, thì phải lấy được ID của dòng đó
            idWhenClick = dtgView.Rows[index].Cells[0].Value.ToString();
            FillData();
        }

        public void FillData()
        {
            //select * from nhanvien where manv = idewhenclick
            var nv = service.GetNhanviens().Where(x => x.Manv == idWhenClick).FirstOrDefault();
            // điền vào các trường textbox
            txt_Mnv.Text = nv.Manv;
            txt_Hoten.Text = nv.Hoten;
            txt_Ngsinh.Text = nv.Ngsinh.ToString();
            txt_Dchi.Text = nv.Dchi;
            txt_Luong.Text = nv.Luong.ToString();
            if(nv.Phai == false)
            {
                rbtn_Nam.Checked = true;
            }
            else
            {
                rbtn_Nu.Checked = true;
            }
        }
    }
}
