using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserOrderManager.Enums
{
    public enum MainMenu
    {
        ListOfUsersOlderThan18 = 1,
        SortUsersByAgeAscending,
        SortUsersByAgeDescending,
        SortByAgeAndNameIfAgesAreEqual,
        JoinUsersAndOrdersUserNameAndOrderPrice,
        GroupUsersByAge,
        ListOfOrdersForEachUser,
        UsersInReverseOrder,
        CheckIfAllUsersAreOlderThan18,
        CheckIfThereIsAtLeastOneUserYoungerThan18,
        CheckIfIdListContains5,
        RemoveDuplicatesFromNameList,
        GetCommonElementsFromTwoLists,
        CountUsersOlderThan18,
        SumOfAllOrders,
        AverageOrderPrice,
        MinimumAge,
        MaximumOrderPrice,
        PaginationTakeFirst5,
        PaginationSkip5AndTakeNext5,
        TakeFromSortedListWhileAgeLessThan30,
        SkipFromSortedListWhileAgeLessThan30,
        FirstUserOlderThan18,
        UserWithId1,
        ThirdElementInTheList,
        LastUserOlderThan18,
        BonusTop3UsersByTotalOrderAmount,
        Exit
    }
}
