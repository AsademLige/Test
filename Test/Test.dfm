object Form1: TForm1
  Left = 0
  Top = 0
  Caption = 'Form1'
  ClientHeight = 402
  ClientWidth = 635
  Color = clBtnFace
  Font.Charset = DEFAULT_CHARSET
  Font.Color = clWindowText
  Font.Height = -11
  Font.Name = 'Tahoma'
  Font.Style = []
  OldCreateOrder = False
  PixelsPerInch = 96
  TextHeight = 13
  object MyDrawCircle1: TMyDrawCircle
    Left = 168
    Top = 80
    Width = 265
    Height = 185
    Size = 185
    ObjColor = clMaroon
    X = 92
    Y = 92
    Color = clMedGray
    ParentColor = False
    ParentShowHint = False
    ShowHint = False
  end
  object UpBtn: TButton
    Left = 257
    Top = 329
    Width = 75
    Height = 25
    Caption = 'Up'
    TabOrder = 0
    OnClick = UpBtnClick
  end
  object DownBtn: TButton
    Left = 257
    Top = 360
    Width = 75
    Height = 25
    Caption = 'Down'
    TabOrder = 1
    OnClick = DownBtnClick
  end
  object RigthBtn: TButton
    Left = 338
    Top = 360
    Width = 75
    Height = 25
    Caption = 'Rigth'
    TabOrder = 2
    OnClick = RigthBtnClick
  end
  object LeftBtn: TButton
    Left = 176
    Top = 360
    Width = 75
    Height = 25
    Caption = 'Left'
    TabOrder = 3
    OnClick = LeftBtnClick
  end
end
