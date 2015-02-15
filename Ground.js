//草地关

function ChosePlantX(X){
	//根据鼠标坐标X范围确定中点X
	switch(true){
		case X>=0&&X<=120:
			X=87;
			break;
		case X>120&&X<=195:
			X=167;
			break;
		case X>195&&X<=278:
			X=247;
			break;
		case X>278&&X<=360:
			X=327;
			break;
		case X>360&&X<=440:
			X=407;
			break;
		case X>440&&X<=522:
			X=487;
			break;
		case X>522&&X<=591:
			X=567;
			break;
		case X>591&&X<=673:
			X=647;
			break;
		default:
			X=727;
	}
	return(X);
}

function ChosePlantY(Y){
	//根据鼠标坐标Y范围确定Y
	switch(true){
		case Y>=0&&Y<=85:
			Y=0;
			break;
		case Y>85&&Y<=180:
			Y=175;R=1;
			break;
		case Y>180&&Y<=280:
			Y=270;R=2;
			break;
		case Y>280&&Y<=385:
			Y=380;R=3;
			break;
		case Y>385&&Y<=475:
			Y=470;R=4;
			break;
		default:
			Y=575;R=5;
	}
	return(Y);
}

function GetPlantC(X){
	//根据X值返回植物的列
	var C;
	switch(X){
		case 87:
			C=1;
			break;
		case 167:
			C=2;
			break;
		case 247:
			C=3;
			break;
		case 327:
			C=4;
			break;
		case 407:
			C=5;
			break;
		case 487:
			C=6;
			break;
		case 567:
			C=7;
			break;
		case 647:
			C=8;
			break;
		default:
			C=9;
	}
	return(C);
}

function GetPlantR(Y){
	//根据Y值返回植物的行
	var R;
	switch(Y){
		case 0:
			R=0;
			break;
		case 175:
			R=1;
			break;
		case 270:
			R=2;
			break;
		case 380:
			R=3;
			break;
		case 470:
			R=4;
			break;
		default:
			R=5;
	}
	return(R);
}

function GetC(X){
	//根据X返回C
	var C;
	switch(true){
		case X<0:
			C=-1;
			break;
		case X>=0&&X<40:
			C=0;
			break;
		case X>=40&&X<120:
			C=1;
			break;
		case X>=120&&X<195:
			C=2;
			break;
		case X>=195&&X<279:
			C=3;
			break;
		case X>=279&&X<360:
			C=4;
			break;
		case X>=360&&X<440:
			C=5;
			break;
		case X>=440&&X<525:
			C=6;
			break;
		case X>=525&&X<595:
			C=7;
			break;
		case X>=595&&X<675:
			C=8;
			break;
		case X>=675&&X<755:
			C=9;
			break;
		case X>=755&&X<835:
			C=10;
			break;
		case X>=835:
			C=11;
	}
	return(C);
}

function GetR(Y){
	//根据Y返回R
	var R; //行
	switch(true){
		case Y>=0&&Y<=85:
			R=0;
			break;
		case Y>85&&Y<=180:
			R=1;
			break;
		case Y>180&&Y<=280:
			R=2;
			break;
		case Y>280&&Y<=385:
			R=3;
			break;
		case Y>385&&Y<=475:
			R=4;
			break;
		default:
			R=5;
	}
	return(R);
}

function GetX(C){
	//根据行返回X坐标
	switch(C){
		case 0:
			X=40;
			break;
		case 1:
			X=87;
			break;
		case 2:
			X=167;
			break;
		case 3:
			X=247;
			break;
		case 4:
			X=327;
			break;
		case 5:
			X=407;
			break;
		case 6:
			X=487;
			break;
		case 7:
			X=567;
			break;
		case 8:
			X=647;
			break;
		case 9:
			X=727;
			break;
		case 10:
			X=765;
			break;
		case 11:
			X=850;
	}
	return(X);
}

function GetY(R){
	//根据行返回Y坐标
	switch(R){
		case 1:
			Y=175;
			break;
		case 2:
			Y=270;
			break;
		case 3:
			Y=380;
			break;
		case 4:
			Y=470;
			break;
		default:
			Y=575;
	}
	return(Y);
}