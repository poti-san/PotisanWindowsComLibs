﻿#pragma warning disable CS1591

namespace Potisan.Windows.Com;

/// <summary>
/// <c>HRESULT</c>の施設コードです。
/// </summary>
public static class HResultFacility
{
	public const uint Null = 0;
	public const uint Rpc = 1;
	public const uint Dispatch = 2;
	public const uint Storage = 3;
	public const uint Itf = 4;
	public const uint Win32 = 7;
	public const uint Windows = 8;
	public const uint Sspi = 9;
	public const uint Security = 9;
	public const uint Control = 10;
	public const uint Cert = 11;
	public const uint Internet = 12;
	public const uint MediaServer = 13;
	public const uint Msmq = 14;
	public const uint SetupAPI = 15;
	public const uint Scard = 16;
	public const uint ComPlus = 17;
	public const uint Aaf = 18;
	public const uint Urt = 19;
	public const uint Acs = 20;
	public const uint DPlay = 21;
	public const uint Umi = 22;
	public const uint Sxs = 23;
	public const uint WindowsCE = 24;
	public const uint Http = 25;
	public const uint UserModeCommonLog = 26;
	public const uint Wer = 27;
	public const uint UserModeFilterManager = 31;
	public const uint BackgroundCopy = 32;
	public const uint Configuration = 33;
	public const uint Wia = 33;
	public const uint StateManagement = 34;
	public const uint MetaDirectory = 35;
	public const uint WindowsUpdate = 36;
	public const uint DirectoryService = 37;
	public const uint Graphics = 38;
	public const uint Shell = 39;
	public const uint Nap = 39;
	public const uint TpmServices = 40;
	public const uint TpmSoftware = 41;
	public const uint UI = 42;
	public const uint Xaml = 43;
	public const uint ActionQueue = 44;
	public const uint Pla = 48;
	public const uint WindowsSetup = 48;
	public const uint Fve = 49;
	public const uint Fwp = 50;
	public const uint WinRM = 51;
	public const uint Ndis = 52;
	public const uint UserModeHypervisor = 53;
	public const uint Cmi = 54;
	public const uint UserModeVirtualization = 55;
	public const uint UserModeVolumeManager = 56;
	public const uint Bcd = 57;
	public const uint UserModeVhd = 58;
	public const uint UserModeHns = 59;
	public const uint Sdiag = 60;
	public const uint WebServices = 61;
	public const uint WinPE = 61;
	public const uint Wpn = 62;
	public const uint WindowsStore = 63;
	public const uint Input = 64;
	public const uint Quic = 65;
	public const uint Eap = 66;
	public const uint IORing = 70;
	public const uint WindowsDefender = 80;
	public const uint Opc = 81;
	public const uint Xps = 82;
	public const uint Mbn = 84;
	public const uint PowerShell = 84;
	public const uint Ras = 83;
	public const uint P2PInt = 98;
	public const uint P2P = 99;
	public const uint Daf = 100;
	public const uint BluetoothAtt = 101;
	public const uint Audio = 102;
	public const uint StateRepository = 103;
	public const uint VisualCpp = 109;
	public const uint Script = 112;
	public const uint Parse = 113;
	public const uint Blb = 120;
	public const uint BlbCli = 121;
	public const uint WsbApp = 122;
	public const uint BlbUI = 128;
	public const uint Usn = 129;
	public const uint UserModeVolumeSnapshot = 130;
	public const uint Tering = 131;
	public const uint WsbOnline = 133;
	public const uint OnlineID = 134;
	public const uint DeviceUpdateAgent = 135;
	public const uint DriverServicing = 136;
	public const uint Dls = 153;
	public const uint DeliveryOptimization = 208;
	public const uint UserModeSpaces = 231;
	public const uint UserModeSecurityCore = 232;
	public const uint UserModeLicensing = 234;
	public const uint Sos = 160;
	public const uint OcpUpdateAgent = 173;
	public const uint Debuggers = 176;
	public const uint Spp = 256;
	public const uint Restore = 256;
	public const uint DMServer = 256;
	public const uint DeploymentServicesServer = 257;
	public const uint DeploymentServicesImaging = 258;
	public const uint DeploymentServicesManagement = 259;
	public const uint DeploymentServicesUtil = 260;
	public const uint DeploymentServicesBinlService = 261;
	public const uint DeploymentServicesPxe = 263;
	public const uint DeploymentServicesTftp = 264;
	public const uint DeploymentServicesTransportManagement = 272;
	public const uint DeploymentServicesDriverProvisioning = 278;
	public const uint DeploymentServicesMulticastServer = 289;
	public const uint DeploymentServicesMulticastClient = 290;
	public const uint DeploymentServicesContentProvider = 293;
	public const uint HspServices = 296;
	public const uint HspSoftware = 297;
	public const uint LinguisticServices = 305;
	public const uint AudioStreaming = 1094;
	public const uint Ttd = 1490;
	public const uint Accelerator = 1536;
	public const uint Wmaaecma = 1996;
	public const uint DirectMusic = 2168;
	public const uint Direct3D10 = 2169;
	public const uint Dxgi = 2170;
	public const uint DxgiDdi = 2171;
	public const uint Direct3D11 = 2172;
	public const uint Direct3D11Debug = 2173;
	public const uint Direct3D12 = 2174;
	public const uint Direct3D12Deug = 2175;
	public const uint DXCore = 2176;
	public const uint Presentation = 2177;
	public const uint Leap = 2184;
	public const uint AudioClient = 2185;
	public const uint WinCodecDWriteDwm = 2200;
	public const uint WinML = 2192;
	public const uint Direct2D = 2201;
	public const uint Defrag = 2304;
	public const uint UserModeSDBus = 2305;
	public const uint JScript = 2306;
	public const uint PidGenX = 2561;
	public const uint Eas = 85;
	public const uint Web = 885;
	public const uint WebSocket = 886;
	public const uint Mobile = 1793;
	public const uint SQLite = 1967;
	public const uint ServiceFabric = 1968;
	public const uint Utc = 1989;
	public const uint Wwp = 2049;
	public const uint SyncEngine = 2050;
	public const uint Xbox = 2339;
	public const uint Game = 2340;
	public const uint UserModeUnionFS = 2341;
	public const uint UserModePrm = 2342;
	public const uint UserModeWinAccel = 2343;
	public const uint Pix = 2748;
}