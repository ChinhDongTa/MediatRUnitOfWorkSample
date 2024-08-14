using DongTa.ApiEndPoint;
using DongTa.ApiEndPoint.Urls;
using DongTa.Domain.Dtos;

namespace DongTa.DesktopUI;

public partial class FrmMain : Form {

    public FrmMain()
    {
        InitializeComponent();
    }

    private async void BtnGetAllAlbum_Click(object sender, EventArgs e)
    {
        Dgv.DataSource = null;
        var apiResultDto = await ApiHelper.GetApiResultDtoAsync<ApiResultDto<AlbumDto>>(CRUDBase.GetAll(ControllerName.AlbumUow));
        LbTitle.Text = "Get all album from api server (Unit Of Work)";
        Dgv.DataSource = apiResultDto?.Dtos;
    }

    private async void BtnGetAllArtist_Click(object sender, EventArgs e)
    {
        Dgv.DataSource = null;
        LbTitle.Text = "Get all Artist from api server (MediatR)";
        var apiResultDto = await ApiHelper.GetApiResultDtoAsync<ApiResultDto<ArtistDto>>(CRUDBase.GetAll(ControllerName.ArtistMediatR));
        Dgv.DataSource = apiResultDto?.Dtos;
    }

    private async void BtnGetAllGenre_Click(object sender, EventArgs e)
    {
        Dgv.DataSource = null;
        LbTitle.Text = "Get all Genre from api server (Unit Of Work)";
        var apiResultDto = await ApiHelper.GetApiResultDtoAsync<ApiResultDto<GenreDto>>(CRUDBase.GetAll(ControllerName.GenreUow));
        Dgv.DataSource = apiResultDto?.Dtos;
    }

    private async void BtnAllPlaylist_Click(object sender, EventArgs e)
    {
        Dgv.DataSource = null;
        LbTitle.Text = "Get all Playlist from api server(MediatR)";
        var apiResultDto = await ApiHelper.GetApiResultDtoAsync<ApiResultDto<PlaylistDto>>(CRUDBase.GetAll(ControllerName.PlaylistMediatR));
        Dgv.DataSource = apiResultDto?.Dtos;
    }
}