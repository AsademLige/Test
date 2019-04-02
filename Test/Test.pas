unit Test;

interface

uses
  Windows, Messages, SysUtils, Variants, Classes, Graphics, Controls, Forms,
  Dialogs, DrawCircle, StdCtrls;

type
  TForm1 = class(TForm)
    MyDrawCircle1: TMyDrawCircle;
    UpBtn: TButton;
    DownBtn: TButton;
    RigthBtn: TButton;
    LeftBtn: TButton;
    procedure UpBtnClick(Sender: TObject);
    procedure DownBtnClick(Sender: TObject);
    procedure LeftBtnClick(Sender: TObject);
    procedure RigthBtnClick(Sender: TObject);
  private
    { Private declarations }
  public
    { Public declarations }
  end;

var
  Form1: TForm1;

implementation

{$R *.dfm}

procedure TForm1.DownBtnClick(Sender: TObject);
begin
  MyDrawCircle1.MoveDown();
end;

procedure TForm1.LeftBtnClick(Sender: TObject);
begin
  MyDrawCircle1.MoveLeft();
end;

procedure TForm1.RigthBtnClick(Sender: TObject);
begin
  MyDrawCircle1.MoveRigth();
end;

procedure TForm1.UpBtnClick(Sender: TObject);
begin
  MyDrawCircle1.MoveUp();
end;

end.
