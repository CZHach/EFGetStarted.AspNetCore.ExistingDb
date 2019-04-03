﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SessionManagement;
using RemoteRecorderManagement;
using EFGetStarted.AspNetCore.ExistingDb.Models;
using EFGetStarted.AspNetCore.ExistingDb.Utilities;

namespace EFGetStarted.AspNetCore.ExistingDb.Scheduling
{
    public interface IScheduleCreationInitiator
    {
        Task<ScheduledRecordingResult> ScheduleRecordings(SchedulingEvent schedulingEvent);
    };
    public sealed class ScheduleCreationInitiator : IScheduleCreationInitiator
    {
        public RemoteRecorderManagement.AuthenticationInfo recorderManagementAuth = new RemoteRecorderManagement.AuthenticationInfo
        {
            UserKey = "letpanoptoapi",
            Password = "Happy@Tappy!pan"
        };

        public async Task<ScheduledRecordingResult> ScheduleRecordings(SchedulingEvent schedulingEvent) 
        {
            ISessionManagement sessionMgr = new SessionManagementClient();

            RemoteRecorderManagementClient recorderClient = new RemoteRecorderManagementClient();
            ScheduledRecordingResult scheduleResult;

            //test recorder
            Guid remoteRecorderId = Guid.Parse("b996f247-377d-46ed-8410-aa170135aea1");

            // test folder
            Guid panoptoFolderId = Guid.Parse("1e957dca-3fe1-4214-b251-a96e0106997a");

            List<RecorderSettings> recorderSettings = new List<RecorderSettings>
            {
                new RecorderSettings { RecorderId = remoteRecorderId }
            };

            // auth, sesson.Name, session.FolderId, session.IsBroadcast, session.start, session.end, recorderSettings // 
            scheduleResult = await recorderClient.ScheduleRecordingAsync(
                recorderManagementAuth,
                schedulingEvent.SessionName,
                panoptoFolderId,
                //schedulingEvent.SessionFolderId,
                false,
                schedulingEvent.SessionStart.ToUniversalTime(),
                schedulingEvent.SessionEnd.ToUniversalTime(),
                recorderSettings.ToArray()
                );
            return scheduleResult;           
        }
    }
}