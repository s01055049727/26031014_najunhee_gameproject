// -------------------------------------------------------------------------------------------------------------------------------------------------------------
// Author: 3dapi (https://github.com/3dapi)
// -------------------------------------------------------------------------------------------------------------------------------------------------------------

using Vortice.Mathematics;

class GameMain : G2AppBase
{
	public override System.Drawing.Size ScreenSize => GameGlobal.ScreenSize;
	public override string GameName => GameGlobal.GameName;

	private G2Texture _bgTexture = null;
	private G2Texture _startTexture = null;
	private G2Texture _enemyTexture = null;
	private G2Texture _titleTexture = null;
	private G2Texture _exitTexture = null;
    /*private G2Texture _downhandTexture = null;
	private G2Texture _uphandTexture = null;
	private G2Texture _refthandTexture = null;
	private G2Texture _lefthandTexture = null;
	private G2Texture _upTexture = null;
	private G2Texture _downTexture = null;
	private G2Texture _reftTexture = null;
	private G2Texture _leftTexture = null;
	private G2Texture _heartTexture = null;
	private G2Texture _emptyheartTexture = null;
	private G2Texture _gameoverTexture = null;
	private G2Texture _gameclearTexture = null;
	private G2Texture _defenseturnTexture = null;
	private G2Texture _attackturnTexture = null;
	*/
    //private G2Font _fntMessage = null;
    //private G2Texture _bgTexture = null;
    protected override void Initialize()

	{
		var texUiDir = "resource/ui/";

		_bgTexture = new G2Texture(texUiDir + "/bg/backgraund.png");
		_titleTexture = new G2Texture(texUiDir + "/message/game_title.png");
		_startTexture = new G2Texture(texUiDir + "/button/start_button.png");
		_enemyTexture = new G2Texture(texUiDir + "enemy.png");
		_exitTexture = new G2Texture(texUiDir + "/button/exit_button.png");
        





        //_fntMessage = new G2Font("arial", 42);
        //---------------------------------------
        // 게임 관련 객체를 생성합니다.
        //---------------------------------------

    }

	protected override void Update()
	{
		double elapsed = TotalTime;

		this.ClearColor = new Color4(
			red: (float)(Math.Sin(elapsed) * 0.5 + 0.5),
			green: (float)(Math.Sin(elapsed + Math.PI / 2.0) * 0.5 + 0.5),
			blue: (float)(Math.Sin(elapsed + Math.PI) * 0.5 + 0.5),
			alpha: 1.0f);

        //---------------------------------------
        // 게임 관련 객체를 갱신합니다.
        //---------------------------------------
        //this._fntMessage.DrawText
		
	}

	protected override void Render()
	{
		//---------------------------------------
		// 게임 관련 객체를 렌더링 합니다.
		//---------------------------------------

		_bgTexture.Draw();
        _titleTexture.Draw(420, -280);
        _startTexture.Draw(300, 600);
		_enemyTexture.Draw(420, 250);
		_exitTexture.Draw(300, 675);


    }

	public override void Dispose()
	{
		base.Dispose();
		//---------------------------------------
		// 게임 관련 객체를 해제합니다.
		//---------------------------------------
		_bgTexture.Dispose();
		_startTexture.Dispose();
		_enemyTexture.Dispose();
		_titleTexture.Dispose();
    }
}
