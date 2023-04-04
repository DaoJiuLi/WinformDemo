/*
 Navicat Premium Data Transfer

 Source Server         : SQL Server
 Source Server Type    : SQL Server
 Source Server Version : 15002000
 Source Host           : .:1433
 Source Catalog        : BaoDan
 Source Schema         : dbo

 Target Server Type    : SQL Server
 Target Server Version : 15000000
 File Encoding         : 65001

 Date: 14/03/2023 20:37:19
*/


-- ----------------------------
-- Table structure for tb_baodan
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[tb_baodan]') AND type IN ('U'))
	DROP TABLE [dbo].[tb_baodan]
GO

CREATE TABLE [dbo].[tb_baodan] (
  [id] int  IDENTITY(1,1) NOT NULL,
  [name] nvarchar(20) COLLATE Chinese_PRC_CI_AS  NOT NULL,
  [age] int  NOT NULL
)
GO

ALTER TABLE [dbo].[tb_baodan] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of tb_baodan
-- ----------------------------
BEGIN TRANSACTION
GO

SET IDENTITY_INSERT [dbo].[tb_baodan] ON
GO

INSERT INTO [dbo].[tb_baodan] ([id], [name], [age]) VALUES (N'1', N'张三', N'18'), (N'2', N'孙安琪', N'82'), (N'3', N'魏詩涵', N'93'), (N'4', N'金睿', N'26'), (N'5', N'袁云熙', N'55'), (N'6', N'阎震南', N'67'), (N'7', N'苏震南', N'76'), (N'8', N'方秀英', N'55'), (N'9', N'顾晓明', N'48'), (N'10', N'石嘉伦', N'28'), (N'11', N'雷云熙', N'23')
GO

SET IDENTITY_INSERT [dbo].[tb_baodan] OFF
GO

COMMIT
GO


-- ----------------------------
-- Auto increment value for tb_baodan
-- ----------------------------
DBCC CHECKIDENT ('[dbo].[tb_baodan]', RESEED, 11)
GO


-- ----------------------------
-- Primary Key structure for table tb_baodan
-- ----------------------------
ALTER TABLE [dbo].[tb_baodan] ADD CONSTRAINT [PK__tb_baoda__3213E83F8A25F309] PRIMARY KEY CLUSTERED ([id])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO

