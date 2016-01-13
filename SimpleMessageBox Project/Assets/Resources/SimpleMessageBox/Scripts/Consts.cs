using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace Main.Assets.Scripts
{
	public class Consts
	{
		public class Params
		{
			public const float TimeOfDisplayForTextToUser = 4f;
			public const float TimeBetweenGameOverAndLoadNewScene = 0.8f;
			public const float FirstRowOfTextYPosition = 7f;
			public const float SecondRowOfTextYPosition = 3.5f;

			public class Bonuses
			{
				
				public const int PriceOf2Life = 500;
				public const int PriceOf3Life = 500;
				public const int PriceOf4Life = 500;
				public const int PriceOf5Life = 1000;

				public const int MinimalSocreToGetRevival = 20;
				public const int PriceOfRevival = 300;

				public const int PriceOfBoost = 800;
				public const int PriceOfUltraBoost = 1300;

				public const int BoostToScore = 150;
				public const int BoostToScoreUnlock = 150;
				public const int UltraBoostToScoreUnlock = 300;
				public const int UltraBoostToScore = 300;
				
				public const int MinGiftReward = 5;
				public const int MaxGiftReward = 150;
				public const int AdReward = 500;
				public const int FacebookRewardPerInvite = 50;
				public const int FacebookRewardPerPost = 100;
				public const int DailyReward = 2000;
			}
		}

		public class Urls
		{

			public const string AppURL = "https://fb.me/173532806329659";
			public const string PlayStoreMarket = "market://details?id=touchit.co.touchit";
			public const string AppStoreMarket = "itms-apps://itunes.apple.com/app/tigabo";
		}
		public class Scenes
		{
			public const string MenuScene = "MenuScene";
			public const string MainGameScene = "MainGameScene";
			public const string NewGameOverScene = "NewGameOverScene";
		}

		public class Lifes
		{
			public const int MaxNumOfLifeOnScreen = 5;
			public const float XCoordinateOfFirstLife = -2.5f;
			public const float YCoordinateOfFirstLife = 0f;
			public const float SpaceBetweenLifes = 1.2f;

			public const float XCoordinateOfFirstLifeWithPlus = -1.2f;
			public const float SpaceBetweenLifesWithPlus = 1f;
		}

		public class Prefabs
		{
			public const string SplashScreenContainer = "SplashScreenContainer";
			public const string LoadingText = "LoadingText";
			public const string ProposeLifesBox = "ProposeLifesBox";
			public const string StartUltraBoostContainer = "StartUltraBoostContainer";
			public const string StartBoostContainer = "StartBoostContainer";
			public const string GiveGiftScreen = "GiveGiftScreen";
			public const string SettingsBox = "SettingsBox";
			public const string RewardLifeIcon = "RewardLifeIcon";
//			public const string RewardCoinsIcon = "RewardCoinsIcon";
			public const string RewardCoinsIconContainer = "RewardCoinsIconContainer";
			public const string MessageBox = "MessageBoxFlat";//NOTICE: IAM USING AN OTHER PREFAB NAME!!!
			public const string TilesAnchor4x4_4Squares = "TilesAnchor4x4_4Squares";
			public const string GameRelatedStatsContainer = "GameRelatedStatsContainer";
			public const string BackgroundRider = "backgroundRider";
			public const string PopUpTextToGoodPlayer = "PopUpTextToGoodPlayer";
			public const string PopUpForSpecials = "Pop Up For Specials";
			public const string PopupScoreAboveTiles = "PopupScoreAboveTiles";
			public const string PopupText = "PopupText";
			public const string HelpersFunctionObject = "HelpersFunctionObject";
			public const string Background = "Background";
			public const string TileCarier = "TileCarier";
			public const string TilesAnchor2x2 = "TilesAnchor2x2";
			public const string TilesAnchor3x3 = "TilesAnchor3x3";
			public const string TilesAnchor4x4 = "TilesAnchor4x4";
			public const string TilesAnchorBars2_3x3 = "TilesAnchorBars2_3x3";
			public const string TilesAnchorBars3_3x3 = "TilesAnchorBars3_3x3";
			public const string TilesAnchorBars1 = "TilesAnchorBars1";
			public const string TilesAnchorCircle = "TilesAnchorCircle";
			public const string TilesAnchorWithSingleMiddle = "TilesAnchorWithSingleMiddle";
			public const string Life = "Life";
		}

		public class Animations
		{
			public class TilesAnchor
			{
				public const string TilesAnchorBars1_UpsAndDownWithRotation = "TilesAnchorBars1_UpsAndDownWithRotation";
				public const string TilesAnchorBar2_PingPong = "TilesAnchorBar2_PingPong";
				public const string TilesAnchorBar2_3x3_sidesOutAndIn = "TilesAnchorBar2_3x3_sidesOutAndIn";
				public const string TilesAnchorBar2VerticalBars = "TilesAnchorBar2VerticalBars";
				public const string TilesAnchorBar2VerticalBars2 = "TilesAnchorBar2VerticalBars2";
				public const string TilesAnchorBars3_StereoSound = "TilesAnchorBars3_StereoSound";
				public const string TilesAnchorBars3_Jumping = "TilesAnchorBars3_Jumping";
				public const string TilesAnchorCircleMoving = "TilesAnchorCircleMoving";
				public const string TilesAnchor4x4_4Squares_Rotate = "TilesAnchor4x4_4Squares_Rotate";
				public const string TilesAnchor4x4_4Squares_toSmalls = "TilesAnchor4x4_4Squares_toSmalls";
				public const string TilesAnchorRotateIn3D = "TilesAnchorRotateIn3D";
				public const string TileAnchorExitDown = "TileAnchorExitDown";
				public const string TileAnchorIntroFromBottom = "TileAnchorIntroFromBottom";
				public const string TilesAnchorCircleToSquare = "TilesAnchorCircleToSquare";
				public const string TileAnchorBar1Maze = "TileAnchorBar1Maze";
				public const string TileAnchorBar1MoveFast = "TileAnchorBar1MoveFast";
				public const string TileAnchorBar1MoveSlowly = "TileAnchorBar1MoveSlowly";
				public const string TileAnchorRotate = "TileAnchorRotate";
				public const string TileAnchorMoveFromRightToCenter = "TileAnchorMoveFromRightToCenter";
				public const string TileAnchorAnimForSingleMiddle = "TileAnchorAnimForSingleMiddle";
				public const string TileAnchorMoveLeftAndOut = "TileAnchorMoveLeftAndOut";
				public const string TileAnchorDefaultBlankAnimation = "TileAnchorDefaultBlankAnimation";
				public const string TilesAnchorDissapear = "TilesAnchorDissapear";
				public const string TileAnchorSetSizeBackFromSmall = "TileAnchorSetSizeBackFromSmall";
				public const string TileAnchorMoveFromSideToSide = "TileAnchorMoveFromSideToSide";
				public const string TileAnchorSetSmall = "TileAnchorSetSmall";
			}
			public const string StartBoostActivated = "StartBoostActivated";
			public const string StartBoostDissapear = "StartBoostDissapear";
			
			public const string StartTileScale = "StartTileScale";
			public const string StartTileClicked = "StartTileClicked";
			public const string StartTileFreeze = "StartTileFreeze";//used by gift button
			
			public const string BottomBarDownToExit = "BottomBarDownToExit";
			public const string BottomBarUpFromBottom = "BottomBarUpFromBottom";
	
			public const string ReloadDissapear = "ReloadDissapear";

			public const string ContainerGoUp = "ContainerGoUp";
			public const string ContainerGoDown = "ContainerGoDown";
			
			public const string BackgroudPink = "BackgroudPink";
			public const string BackgroudRed = "BackgroudRed";
			public const string BackgroundUnfadeContainer = "BackgroundUnfadeContainer";
			public const string BackgroudUnfade = "BackgroudUnfade";
			public const string BackgroundClearBlue = "BackgroundClearBlue";
			public const string BackgroundDark = "BackgroundDark";
			public const string BackgroundFadeContainer = "BackgroundFadeContainer";
			public const string BackgroundFade = "BackgroundFade";
			public const string BackgroundPurple = "BackgroundPurple";
			public const string BackgroundRegular = "BackgroundRegular";
			public const string BackgroundTilt = "BackgroundTilt";
			public const string BackgroundTiltContainer = "BackgroundTiltContainer";
			public const string BackgroundTransition = "BackgroundTransition";
			public const string BackroundYellow = "BackroundYellow";
	
			public const string Dissapear = "Dissapear";
			public const string FlashingPopUpSpecial = "FlashingPopUpSpecial";
			public const string PopUpScore = "PopUpScore";
			public const string PopUpTextToGoodPlayer = "PopUpTextToGoodPlayer";
			public const string Regular = "regular";
			public const string ReloadAppear = "ReloadAppear";
			public const string TileAppears = "Tile Appears";
			public const string TileClicked = "TileClicked";
			public const string TileFlashing = "TileFlashing";
			public const string TileMoveToCenter = "TileMoveToCenter";
			public const string TileMoveToLeft = "TileMoveToLeft";
			public const string TileWasBadSoGameOver = "TileWasBadSoGameOver";
			public const string Tilting = "Tilting";

			public class GiftScreen
			{
				public const string GiftOpenned = "GiftOpenned";
			}

			public class settingsBox
			{
				public const string SettingBoxDissapear = "SettingBoxDissapear";
			}
			public class MessageBox
			{
				public const string MessageBoxDissappear = "MessageBoxDissappear";
				public const string MessageBoxAppear = "MessageBoxAppear";
			}
			public class ProposeLifeBox
			{
				public const string ProposeLifeAppear = "ProposeLifeAppear";
				public const string ProposeLifeDisappear = "ProposeLifeDisappear";
			}
		}

		public class StringsForUser
		{
			public const string Example1 = "this is a basic textBox";
		}

		public class Tags
		{
			public class StartBoost
			{
				public const string JumpTo = "JumpTo";
				public const string Price = "Price";
			}

			public class ProposeLifeBox
			{
				public const string Life2 = "Life2";
				public const string Life3 = "Life3";
				public const string Life4 = "Life4";
				public const string Life5 = "Life5";
			}
			public const string MessageBoxBlur = "MessageBoxBlur";
			public const string MessageBox = "MessageBox";
			public const string MessageBoxText = "MessageBoxText";
			public const string MessageBoxYes = "MessageBoxYes";
			public const string MessageBoxNo = "MessageBoxNo";

			public const string VibrateOption = "VibrateOption";
			public const string SoundOption = "SoundOption";
			public const string CloseOption = "CloseOption";
			public const string CreditsOption = "CreditsOption";

			public const string AdProposeContainer = "AdProposeContainer";
			
			public const string GiftContainerBackground = "GiftContainerBackground";
			public const string GiftContainer = "GiftContainer";
			
			public const string CoinsAcountCanvas = "CoinsAcountCanvas";
			
			public const string BottomBarContainer = "BottomBarContainer";
			
			public const string GameRelatedAndCoinsContainer = "GameRelatedAndCoinsContainer";
			public const string GameRelatedStatsContainer = "GameRelatedStatsContainer";

			public const string GameEngine = "GameEngine";
			public const string Helpers = "Helpers";
			public const string Level = "Level";
			
			public const string ClickAmount = "ClickAmount";
			
			public const string Untagged = "Untagged";
			
			public const string Background = "Background";
			public const string BackgroundContainer = "BackgroundContainer";
			
			public const string TileCarier = "TileCarier";
			public const string Tile = "Tile";
			
			public const string ProgressImage = "ProgressImage";
			
			public const string Score = "Score";
			public const string Highscore = "Highscore";
			public const string BestScore = "BestScore";
			public const string HighscoreText = "HighscoreText";
			public const string ScoreText = "ScoreText";
			
			public const string TilesAnchor = "TilesAnchor";
			
			public const string LifesContainer = "LifesContainer";
			public const string Life = "Life";
			
			public const string BackgroundRider = "BackgroundRider";
		}

		public class Images
		{
			public class PicsOnBlacks
			{
				public const string JustinBieber2 = "justinBieber2";
				public const string JustinBieber = "justinBieber";
				public const string CircularProgressBar = "CircularProgressBar";
			}
			
			public const string SuperbombTile = "SuperbombTile";
			public const string HeartTile = "HeartTile";
			public const string BrokenHeart = "BrokenHeart";
			public const string Hearts = "Hearts";
			public const string TileBackground = "TileBackground";
			public const string NewFastforward = "NewFastforward";
			public const string Multiply2 = "Multiply2";
			public const string BonusTile = "BonusTile";
			public const string SkullTile = "SkullTile";
			public const string Triangle1 = "triangle1";
			public const string Triangle2 = "triangle2";
			public const string Triangle3 = "triangle3";
		}

		public class Leaderboards
		{
			public const string Highscores = "CgkI_IzPo7YBEAIQBg";
			public const string Levels = "CgkI_IzPo7YBEAIQCA";
			public const string TilesClicked = "CgkI_IzPo7YBEAIQCQ";
			public const string OldTestLeaderboard = "CgkI_IzPo7YBEAIQBw";
			public const string TestLeaderboard = "CgkI_IzPo7YBEAIQDg";

		}

		public class Sounds
		{

			public const string giveLifeSound = "giveLifeSound";
			public const string tilesound = "tilesound";
			public const string badtilesound = "badtilesound";
			public const string failedsound = "failedsound";
			public const string cheeringhighscore = "cheeringhighscore";
			public const string Coins_Several_16 = "Coins_Several_16";//single coin
			public const string Coins_Several_17 = "Coins_Several_17";//multiple coins

		}
	}
}
