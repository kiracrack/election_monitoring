Imports DevExpress.XtraEditors
Imports DevExpress.XtraSplashScreen

Module UpdateEngine
    Dim engineupdated As Boolean = False
    Public Sub SystemUpdateChecker()
        On Error Resume Next
        Dim updateVersion As String = ""

        updateVersion = "2015-09-18"
        If CBool(qrysingledata1("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "ALTER TABLE `tblvoters` ADD COLUMN `contactnumber` VARCHAR(45) AFTER `address`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "CREATE TABLE  `tblsmsinbox` (  `id` int(10) unsigned NOT NULL AUTO_INCREMENT,  `sender` varchar(45) NOT NULL,  `sendername` varchar(100) NOT NULL DEFAULT '',  `area` text,  `city` text,  `barangay` text,  `purok` text,  `precinct` varchar(45) DEFAULT NULL,  `message` text NOT NULL,  `smsdatetime` datetime NOT NULL,  `isread` int(10) unsigned NOT NULL DEFAULT '0',  `deleted` int(10) unsigned NOT NULL DEFAULT '0',  `deletedby` varchar(100) DEFAULT NULL,  `datedeleted` datetime DEFAULT NULL,  PRIMARY KEY (`id`)) ENGINE=InnoDB AUTO_INCREMENT=106 DEFAULT CHARSET=latin1 ROW_FORMAT=DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "CREATE TABLE  `tblsmsoutbox` (  `id` int(10) unsigned NOT NULL AUTO_INCREMENT,  `recipient` varchar(45) NOT NULL,  `recipientname` varchar(100) NOT NULL,  `area` text,  `city` text,  `barangay` text,  `purok` text,  `precinct` varchar(45) DEFAULT NULL,  `message` text NOT NULL,  `smsdatetime` datetime NOT NULL,  `senderid` varchar(45) NOT NULL DEFAULT '0',  `groupsms` tinyint(1) NOT NULL DEFAULT '0',  PRIMARY KEY (`id`)) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=latin1 ROW_FORMAT=DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "CREATE TABLE  `tblpurok` (  `purokcode` varchar(45) NOT NULL,  `villcode` varchar(45) NOT NULL,  `areacode` varchar(45) NOT NULL,  `muncode` varchar(45) NOT NULL,  `purokname` text NOT NULL,  `status` int(1) NOT NULL DEFAULT '1',  PRIMARY KEY (`purokcode`)) ENGINE=InnoDB DEFAULT CHARSET=latin1;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "CREATE TABLE  `tblsmsgroupname` (  `id` int(10) unsigned NOT NULL AUTO_INCREMENT,  `groupname` varchar(45) NOT NULL,  PRIMARY KEY (`id`)) ENGINE=InnoDB AUTO_INCREMENT=102 DEFAULT CHARSET=latin1 ROW_FORMAT=DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "CREATE TABLE  `tblsmsgroupitem` (  `id` int(10) unsigned NOT NULL AUTO_INCREMENT,  `groupcode` varchar(45) NOT NULL,  `mobilenumber` varchar(45) NOT NULL,  `fullname` varchar(100) NOT NULL,  PRIMARY KEY (`id`)) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1 ROW_FORMAT=DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "CREATE TABLE  `tblsmstemplate` (  `id` int(10) unsigned NOT NULL AUTO_INCREMENT,  `title` varchar(50) NOT NULL,  `body` text NOT NULL,  PRIMARY KEY (`id`)) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=latin1 ROW_FORMAT=DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE  `tblvoters` ADD COLUMN `purokcode` VARCHAR(105) AFTER `vilcode`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblvoters` MODIFY COLUMN `fullname` VARCHAR(105) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL DEFAULT '', MODIFY COLUMN `address` TEXT CHARACTER SET latin1 COLLATE latin1_swedish_ci, MODIFY COLUMN `contactnumber` VARCHAR(45) CHARACTER SET latin1 COLLATE latin1_swedish_ci DEFAULT '', MODIFY COLUMN `bdate` VARCHAR(45) CHARACTER SET latin1 COLLATE latin1_swedish_ci DEFAULT '', MODIFY COLUMN `sex` VARCHAR(6) CHARACTER SET latin1 COLLATE latin1_swedish_ci DEFAULT '', MODIFY COLUMN `vtype` VARCHAR(10) CHARACTER SET latin1 COLLATE latin1_swedish_ci DEFAULT '', MODIFY COLUMN `areacode` VARCHAR(45) CHARACTER SET latin1 COLLATE latin1_swedish_ci DEFAULT '', MODIFY COLUMN `muncode` VARCHAR(45) CHARACTER SET latin1 COLLATE latin1_swedish_ci DEFAULT '', MODIFY COLUMN `vilcode` VARCHAR(45) CHARACTER SET latin1 COLLATE latin1_swedish_ci DEFAULT '', MODIFY COLUMN `entryby` INT(10) UNSIGNED, MODIFY COLUMN `remarks` TEXT CHARACTER SET latin1 COLLATE latin1_swedish_ci, MODIFY COLUMN `editedby` INT(10) UNSIGNED;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "CREATE DATABASE IF NOT EXISTS `filedir`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "CREATE TABLE  `filedir`.`tblvotersimage` (  `id` int(10) unsigned NOT NULL AUTO_INCREMENT,  `votersid` varchar(105) CHARACTER SET latin1 NOT NULL,  `imgprofile` longblob,  `barcode` longblob,  PRIMARY KEY (`id`)) ENGINE=MyISAM AUTO_INCREMENT=1 DEFAULT CHARSET=utf8;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If

        updateVersion = "2015-11-04"
        If CBool(qrysingledata1("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "CREATE TABLE  `tblclientsystemupdate` (  `id` int(10) unsigned NOT NULL AUTO_INCREMENT,  `details` text,  `version` varchar(45) NOT NULL,  `downloadurl` text NOT NULL,  `features` text NOT NULL,  `password` text NOT NULL,  `active` tinyint(1) NOT NULL DEFAULT '1',  `server` tinyint(1) NOT NULL DEFAULT '0',  PRIMARY KEY (`id`)) ENGINE=InnoDB AUTO_INCREMENT=14 DEFAULT CHARSET=latin1 ROW_FORMAT=DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `settings`.`tblsettings` DROP COLUMN `islock`, DROP COLUMN `islicense`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `settings`.`tblactionquerylogs` ADD COLUMN `img` LONGBLOB AFTER `performedby`, ROW_FORMAT = DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `settings`.`tblactionbackuplogs` ADD COLUMN `img` LONGBLOB AFTER `batchcode`, ROW_FORMAT = DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If
        updateVersion = "2015-11-05"
        If CBool(qrysingledata1("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "ALTER TABLE `settings`.`tblsettings` ADD COLUMN `downloadurl` TEXT AFTER `smscomport`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If

        updateVersion = "2015-11-07"
        If CBool(qrysingledata1("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "ALTER TABLE `tblleaders` MODIFY COLUMN `leadersid` VARCHAR(45) NOT NULL;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblsmsgroupitem` DROP COLUMN `id`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblsmsgroupname` MODIFY COLUMN `id` VARCHAR(45) NOT NULL;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblsmsinbox` MODIFY COLUMN `id` VARCHAR(45) NOT NULL;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblsmsoutbox` MODIFY COLUMN `id` VARCHAR(45) NOT NULL;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblsmstemplate` MODIFY COLUMN `id` VARCHAR(45) NOT NULL;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblvotersdeleted` MODIFY COLUMN `id` VARCHAR(45) NOT NULL;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "CREATE TABLE `tblfamilymember` (  `id` varchar(45) NOT NULL,  `votersid` varchar(205) NOT NULL,  `fullname` varchar(505) NOT NULL,  `relationship` varchar(100) NOT NULL,  PRIMARY KEY (`id`)) ENGINE=InnoDB DEFAULT CHARSET=latin1;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblvoters` ADD COLUMN `deceased` BOOLEAN NOT NULL DEFAULT 0 AFTER `editedby`, ADD COLUMN `datedeceased` DATE AFTER `deceased`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "CREATE TABLE `tbleducation` (  `id` varchar(45) NOT NULL,  `votersid` varchar(205) NOT NULL,  `schoolname` varchar(505) NOT NULL,  `schooladdress` varchar(505) NOT NULL,  `dateattended` date DEFAULT NULL,  `iscurrent` tinyint(1) NOT NULL DEFAULT '0',  PRIMARY KEY (`id`)) ENGINE=InnoDB DEFAULT CHARSET=latin1;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If

        updateVersion = "2015-11-08"
        If CBool(qrysingledata1("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "ALTER TABLE `tblleaders` ADD COLUMN `leadername` VARCHAR(505) NOT NULL AFTER `votersid`, ROW_FORMAT = DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblleaders` ADD COLUMN `totalmember` DOUBLE NOT NULL DEFAULT 0 AFTER `precinct`, ROW_FORMAT = DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblvoters` MODIFY COLUMN `leaderid` VARCHAR(205) CHARACTER SET latin1 COLLATE latin1_swedish_ci DEFAULT 0;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            'com.CommandText = "UPDATE tblleaders set leadername = (select fullname from tblvoters where tblvoters.votersid= tblleaders.votersid);" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            'com.CommandText = "UPDATE tblleaders set totalmember = (select count(*) from tblvoters where tblvoters.leaderid= tblleaders.votersid);" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If

        updateVersion = "2015-11-09"
        If CBool(qrysingledata1("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "CREATE TABLE `tblwork` (  `id` varchar(45) NOT NULL,  `votersid` varchar(205) NOT NULL,  `companyname` varchar(505) NOT NULL,  `companyaddress` varchar(505) NOT NULL,  `position` varchar(505) NOT NULL,  `datefrom` date DEFAULT NULL,  `dateto` date DEFAULT NULL,  `iscurrent` tinyint(1) NOT NULL DEFAULT '0',  PRIMARY KEY (`id`)) ENGINE=InnoDB DEFAULT CHARSET=latin1;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If

        updateVersion = "2015-11-10"
        If CBool(qrysingledata1("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "ALTER TABLE `settings`.`tblsettings` DROP COLUMN `defprintjettype`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `settings`.`tblsettings` ADD COLUMN `webtypeprinter` BOOLEAN NOT NULL DEFAULT 0 AFTER `id`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If

        updateVersion = "2015-12-16"
        If CBool(qrysingledata1("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "ALTER TABLE `tblconfiguration` ADD COLUMN `autocolorleadersmember` BOOLEAN NOT NULL DEFAULT 1 AFTER `defmembercolor`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblleaders` ADD COLUMN `colorcode` VARCHAR(45) NOT NULL AFTER `editedby`, ROW_FORMAT = DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If

        updateVersion = "2016-01-14"
        If CBool(qrysingledata1("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "ALTER TABLE `tblwork` ADD COLUMN `workstatus` VARCHAR(500) NOT NULL DEFAULT '' AFTER `iscurrent`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If

        updateVersion = "2016-02-26"
        If CBool(qrysingledata1("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "ALTER TABLE `tblconfiguration` ADD COLUMN `multipleidprint` BOOLEAN NOT NULL DEFAULT 0 AFTER `autocolorleadersmember`, ADD COLUMN `showidprintpreview` BOOLEAN NOT NULL DEFAULT 1 AFTER `multipleidprint`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblleaders` ADD COLUMN `idprint` BOOLEAN NOT NULL DEFAULT 0 AFTER `colorcode`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblvoters` ADD COLUMN `idprint` BOOLEAN NOT NULL DEFAULT 0 AFTER `datedeceased`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblvotersdeleted` ADD COLUMN `idprint` BOOLEAN NOT NULL DEFAULT 0 AFTER `datedeceased`, ROW_FORMAT = DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblaccounts` ADD COLUMN `team` VARCHAR(1) NOT NULL DEFAULT '' AFTER `theme`, ROW_FORMAT = DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If

        updateVersion = "2016-03-16"
        If CBool(qrysingledata1("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "ALTER TABLE `settings`.`tblsettings` ADD COLUMN `showclientstatusresult` BOOLEAN NOT NULL DEFAULT 0 AFTER `downloadurl`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If

        updateVersion = "2016-04-05"
        If CBool(qrysingledata1("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "ALTER TABLE `tblaccounts` ADD COLUMN `defaultleaderbackcolor` VARCHAR(45) DEFAULT 'LemonChiffon' AFTER `team`, ADD COLUMN `defaultforecolormember` VARCHAR(45) AFTER `defaultleaderbackcolor`, ROW_FORMAT = DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If

        updateVersion = "2016-04-11"
        If CBool(qrysingledata1("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "ALTER TABLE `tblleaders` ADD COLUMN `birthdate` VARCHAR(45) NOT NULL DEFAULT '' AFTER `leadername`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "UPDATE tblleaders inner join tblvoters on tblvoters.votersid = tblleaders.votersid set birthdate=ifnull(bdate,'');" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If

        updateVersion = "2018-11-09"
        If CBool(qrysingledata1("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "ALTER TABLE `tblaccounts` ADD COLUMN `filteroption` INTEGER UNSIGNED NOT NULL DEFAULT 0 AFTER `defaultforecolormember`, ADD COLUMN `areacode` VARCHAR(45) NOT NULL DEFAULT '' AFTER `filteroption`, ADD COLUMN `muncode` VARCHAR(45) NOT NULL DEFAULT '' AFTER `areacode`, ADD COLUMN `brgycode` VARCHAR(45) NOT NULL DEFAULT '' AFTER `muncode`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If

        updateVersion = "2018-11-10"
        If CBool(qrysingledata1("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "CREATE TABLE  `tblcolumnindex` (  `form` varchar(45) NOT NULL,  `gridview` varchar(100) NOT NULL,  `columnname` varchar(100) NOT NULL,  `columnwidth` double NOT NULL DEFAULT '0',  `colindex` double NOT NULL) ENGINE=MyISAM DEFAULT CHARSET=latin1 ROW_FORMAT=DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If

        updateVersion = "2018-11-11"
        If CBool(qrysingledata1("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "ALTER TABLE `tblidcategory` ADD COLUMN `idtemplate` VARCHAR(45) NOT NULL DEFAULT 'id' AFTER `description`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If

        updateVersion = "2018-11-12"
        If CBool(qrysingledata1("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "ALTER TABLE `tblvoters` ADD COLUMN `subleaderid` VARCHAR(45) NOT NULL DEFAULT 0 AFTER `leaderid`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblvoters` ADD INDEX `subleaderid`(`subleaderid`);" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))

            engineupdated = True
        End If


        updateVersion = "2019-03-17"
        If CBool(qrysingledata1("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "ALTER TABLE `tblvoters` ADD COLUMN `stubclaimed` BOOLEAN NOT NULL DEFAULT 0 AFTER `idprint`, ADD COLUMN `stubclaimedby` VARCHAR(45) NOT NULL DEFAULT '' AFTER `stubclaimed`, ADD COLUMN `watchersclaimed` BOOLEAN NOT NULL DEFAULT 0 AFTER `stubclaimedby`, ADD COLUMN `watchersclaimedby` VARCHAR(45) NOT NULL DEFAULT '' AFTER `watchersclaimed`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "CREATE TABLE `tblstubclaimedcopy` (  `id` INTEGER UNSIGNED NOT NULL AUTO_INCREMENT,  `votersid` VARCHAR(10) NOT NULL,  `claimedid` VARCHAR(10) NOT NULL,  `trnby` VARCHAR(10)  NOT NULL,  `datetrn` datetime,  PRIMARY KEY (`id`),  INDEX `votersid`(`votersid`))ENGINE = InnoDB;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "CREATE TABLE `tblstubwatcherscopy` (  `id` INTEGER UNSIGNED NOT NULL AUTO_INCREMENT,  `votersid` VARCHAR(10) NOT NULL,  `watcherid` VARCHAR(10) NOT NULL, `trnby` VARCHAR(10)  NOT NULL,  `datetrn` datetime,  PRIMARY KEY (`id`),  INDEX `votersid`(`votersid`))ENGINE = InnoDB;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If

        updateVersion = "2019-03-19"
        If CBool(qrysingledata1("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "ALTER TABLE `tblidcategory` ADD COLUMN `customized` BOOLEAN NOT NULL DEFAULT 0 AFTER `idtemplate`, ROW_FORMAT = DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If

        updateVersion = "2019-04-24"
        If CBool(qrysingledata1("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "ALTER TABLE `tblvoters` ADD COLUMN `stubprinted` BOOLEAN NOT NULL DEFAULT 0 AFTER `idprint`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If

        updateVersion = "2019-04-25"
        If CBool(qrysingledata1("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "ALTER TABLE `tblaccounts` ADD COLUMN `fullaccess` BOOLEAN NOT NULL DEFAULT 0 AFTER `brgycode`, ADD COLUMN `accessareacode` VARCHAR(45) NOT NULL DEFAULT '' AFTER `fullaccess`, ADD COLUMN `accessmuncode` VARCHAR(45) NOT NULL DEFAULT '' AFTER `accessareacode`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If

        updateVersion = "2019-04-26"
        If CBool(qrysingledata1("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "ALTER TABLE `tblcolor` ADD COLUMN `shortcut` VARCHAR(2) NOT NULL AFTER `defaults`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If

        updateVersion = "2019-04-27"
        If CBool(qrysingledata1("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "update tblvoters set stubprinted=0" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If

        updateVersion = "2020-04-23"
        If CBool(qrysingledata1("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "ALTER TABLE `tblvoters` ADD COLUMN `couponassistance` BOOLEAN NOT NULL DEFAULT 0 AFTER `idprint`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If

        If engineupdated = True Then
            XtraMessageBox.Show("Your database engine was updated to Build Version " & updateVersion & Environment.NewLine & "Please view update list at ""Main System Menu"" > About > What's New! ", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
            engineupdated = False
        End If
    End Sub
    Public Function DatabaseUpdateLogs(ByVal nVersions As String, ByVal strQuery As String)
        com.CommandText = "insert into tbldatabaseupdatelogs set databaseversion='" & nVersions & "',dateupdate=current_timestamp,appliedquery='" & strQuery & "'" : com.ExecuteNonQuery()
        Return 0
    End Function
End Module
